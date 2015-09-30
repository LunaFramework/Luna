﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Event : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.Event o;
			if(argc==1){
				o=new UnityEngine.Event();
				pushValue(l,o);
				return 1;
			}
			else if(argc==2){
				UnityEngine.Event a1;
				checkType(l,2,out a1);
				o=new UnityEngine.Event(a1);
				pushValue(l,o);
				return 1;
			}
			LuaDLL.luaL_error(l,"New object failed.");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTypeForControl(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetTypeForControl(a1);
			pushEnum(l,(int)ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Use(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			self.Use();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int PopEvent_s(IntPtr l) {
		try {
			UnityEngine.Event a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Event.PopEvent(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetEventCount_s(IntPtr l) {
		try {
			var ret=UnityEngine.Event.GetEventCount();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int KeyboardEvent_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Event.KeyboardEvent(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rawType(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushEnum(l,(int)self.rawType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_type(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushEnum(l,(int)self.type);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_type(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			UnityEngine.EventType v;
			checkEnum(l,2,out v);
			self.type=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mousePosition(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.mousePosition);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mousePosition(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.mousePosition=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_delta(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.delta);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_delta(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			UnityEngine.Vector2 v;
			checkType(l,2,out v);
			self.delta=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_button(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.button);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_button(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.button=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_modifiers(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushEnum(l,(int)self.modifiers);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_modifiers(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			UnityEngine.EventModifiers v;
			checkEnum(l,2,out v);
			self.modifiers=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressure(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.pressure);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressure(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.pressure=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clickCount(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.clickCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_clickCount(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.clickCount=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_character(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.character);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_character(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			System.Char v;
			checkType(l,2,out v);
			self.character=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_commandName(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.commandName);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_commandName(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.commandName=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyCode(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushEnum(l,(int)self.keyCode);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyCode(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			UnityEngine.KeyCode v;
			checkEnum(l,2,out v);
			self.keyCode=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shift(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.shift);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shift(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.shift=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_control(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.control);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_control(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.control=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_alt(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.alt);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_alt(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.alt=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_command(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.command);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_command(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.command=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_capsLock(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.capsLock);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_capsLock(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.capsLock=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_numeric(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.numeric);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_numeric(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.numeric=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_functionKey(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.functionKey);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_current(IntPtr l) {
		try {
			pushValue(l,UnityEngine.Event.current);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_current(IntPtr l) {
		try {
			UnityEngine.Event v;
			checkType(l,2,out v);
			UnityEngine.Event.current=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isKey(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.isKey);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isMouse(IntPtr l) {
		try {
			UnityEngine.Event self=(UnityEngine.Event)checkSelf(l);
			pushValue(l,self.isMouse);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Event");
		addMember(l,GetTypeForControl);
		addMember(l,Use);
		addMember(l,PopEvent_s);
		addMember(l,GetEventCount_s);
		addMember(l,KeyboardEvent_s);
		addMember(l,"rawType",get_rawType,null,true);
		addMember(l,"type",get_type,set_type,true);
		addMember(l,"mousePosition",get_mousePosition,set_mousePosition,true);
		addMember(l,"delta",get_delta,set_delta,true);
		addMember(l,"button",get_button,set_button,true);
		addMember(l,"modifiers",get_modifiers,set_modifiers,true);
		addMember(l,"pressure",get_pressure,set_pressure,true);
		addMember(l,"clickCount",get_clickCount,set_clickCount,true);
		addMember(l,"character",get_character,set_character,true);
		addMember(l,"commandName",get_commandName,set_commandName,true);
		addMember(l,"keyCode",get_keyCode,set_keyCode,true);
		addMember(l,"shift",get_shift,set_shift,true);
		addMember(l,"control",get_control,set_control,true);
		addMember(l,"alt",get_alt,set_alt,true);
		addMember(l,"command",get_command,set_command,true);
		addMember(l,"capsLock",get_capsLock,set_capsLock,true);
		addMember(l,"numeric",get_numeric,set_numeric,true);
		addMember(l,"functionKey",get_functionKey,null,true);
		addMember(l,"current",get_current,set_current,false);
		addMember(l,"isKey",get_isKey,null,true);
		addMember(l,"isMouse",get_isMouse,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Event));
	}
}
