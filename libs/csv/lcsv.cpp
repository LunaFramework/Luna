
#include "csv_parser.h"
extern "C" {
#include "lua.h"
#include "lualib.h"
#include "lauxlib.h"
}



int lua_csv_parser_total_lines(lua_State *L)
{
    csv_parser* cobj = (csv_parser*)lua_touserdata(L, 1);
    if (cobj == 0) return 0;
    int ret = cobj->total_lines();
    lua_pushnumber(L, ret);
    return 1;
}

int lua_csv_parser_get_value(lua_State *L)
{
    csv_parser* cobj = (csv_parser*)lua_touserdata(L, 1);
    if (cobj == 0) return 0;
    int row = lua_tointeger(L, 2);
    int col = lua_tointeger(L, 3);
    int length = 0;
    const char* str = cobj->get_value(row, col, length);
    if (length == 0){
        lua_pushnil(L);
    } else {
        lua_pushlstring(L, str, length);
    }
    return 1;
}

int lua_csv_parser_fields(lua_State *L)
{
    csv_parser* cobj = (csv_parser*)lua_touserdata(L, 1);
    if (cobj == 0) return 0;
    int line = lua_tonumber(L, 2);
    int ret = cobj->fields(line);
    lua_pushnumber(L, ret);
    return 1;
}

int lua_csv_parser_create(lua_State *L)
{
    csv_parser* cobj = new csv_parser();
    lua_pushlightuserdata(L, cobj);
    return 1;
}

int lua_csv_parser_release(lua_State* L)
{
    csv_parser* cobj = (csv_parser*)lua_touserdata(L, 1);
    if (cobj == 0) return 0;
    delete cobj;
    return 0;
}

int lua_csv_parser_keep(lua_State* L)
{
    csv_parser* cobj = (csv_parser*)lua_touserdata(L, 1);
    if (cobj == 0) return 0;
    size_t len = 0;
    const char* buff = lua_tolstring(L, 2, &len);
    cobj->keep(buff, len);
    return 0;
}

int lua_csv_parser_parser(lua_State* L)
{
    csv_parser* cobj = (csv_parser*)lua_touserdata(L, 1);
    if (cobj == 0) return 0;
    
    int argc = lua_gettop(L) - 1;
    if (argc == 0){
        cobj->parser();
    } else if (argc == 1){
        const char* delimit = lua_tostring(L, 2);
        cobj->parser(*delimit);
    } else if (argc == 2){
        const char* delimit = lua_tostring(L, 2);
        const char* protect_area = lua_tostring(L, 3);
        cobj->parser(*delimit, *protect_area);
    }
    
    return 0;
}


#if LUA_VERSION_NUM < 502
# define lua_rawlen lua_objlen
/* lua_...uservalue: Something very different, but it should get the job done */
# define lua_getuservalue lua_getfenv
# define lua_setuservalue lua_setfenv
# define luaL_newlib(L,l) (lua_newtable(L), luaL_register(L,NULL,l))
# define luaL_setfuncs(L,l,n) (assert(n==0), luaL_register(L,NULL,l))
# define lua_resume(L,F,n) lua_resume(L,n)
# define lua_pushglobaltable(L) lua_pushvalue(L, LUA_GLOBALSINDEX)
#endif


static const luaL_Reg lcsv_functions[] = {
    {"create", lua_csv_parser_create},
    {"release", lua_csv_parser_release},
    {"keep", lua_csv_parser_keep},
    {"parser", lua_csv_parser_parser},
    {"totalline", lua_csv_parser_total_lines},
    {"fields", lua_csv_parser_fields},
    {"value", lua_csv_parser_get_value},
    {NULL, NULL}
};

extern "C" {
    int luaopen_csv(lua_State *L)
    {
        luaL_newlib(L, lcsv_functions);
        return 1;
    }
}



