﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_ContactPoint : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.ContactPoint o;
			o=new UnityEngine.ContactPoint();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_point(IntPtr l) {
		try {
			UnityEngine.ContactPoint self;
			checkType(l,1,out self);
			pushValue(l,self.point);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		try {
			UnityEngine.ContactPoint self;
			checkType(l,1,out self);
			pushValue(l,self.normal);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_thisCollider(IntPtr l) {
		try {
			UnityEngine.ContactPoint self;
			checkType(l,1,out self);
			pushValue(l,self.thisCollider);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_otherCollider(IntPtr l) {
		try {
			UnityEngine.ContactPoint self;
			checkType(l,1,out self);
			pushValue(l,self.otherCollider);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.ContactPoint");
		addMember(l,"point",get_point,null,true);
		addMember(l,"normal",get_normal,null,true);
		addMember(l,"thisCollider",get_thisCollider,null,true);
		addMember(l,"otherCollider",get_otherCollider,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.ContactPoint),typeof(System.ValueType));
	}
}
