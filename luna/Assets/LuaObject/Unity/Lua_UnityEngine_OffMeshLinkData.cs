﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_OffMeshLinkData : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.OffMeshLinkData o;
			o=new UnityEngine.OffMeshLinkData();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_valid(IntPtr l) {
		try {
			UnityEngine.OffMeshLinkData self;
			checkType(l,1,out self);
			pushValue(l,self.valid);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_activated(IntPtr l) {
		try {
			UnityEngine.OffMeshLinkData self;
			checkType(l,1,out self);
			pushValue(l,self.activated);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_linkType(IntPtr l) {
		try {
			UnityEngine.OffMeshLinkData self;
			checkType(l,1,out self);
			pushEnum(l,(int)self.linkType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_startPos(IntPtr l) {
		try {
			UnityEngine.OffMeshLinkData self;
			checkType(l,1,out self);
			pushValue(l,self.startPos);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_endPos(IntPtr l) {
		try {
			UnityEngine.OffMeshLinkData self;
			checkType(l,1,out self);
			pushValue(l,self.endPos);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_offMeshLink(IntPtr l) {
		try {
			UnityEngine.OffMeshLinkData self;
			checkType(l,1,out self);
			pushValue(l,self.offMeshLink);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.OffMeshLinkData");
		addMember(l,"valid",get_valid,null,true);
		addMember(l,"activated",get_activated,null,true);
		addMember(l,"linkType",get_linkType,null,true);
		addMember(l,"startPos",get_startPos,null,true);
		addMember(l,"endPos",get_endPos,null,true);
		addMember(l,"offMeshLink",get_offMeshLink,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.OffMeshLinkData),typeof(System.ValueType));
	}
}
