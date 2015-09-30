﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Joint2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Joint2D o;
			o=new UnityEngine.Joint2D();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_connectedBody(IntPtr l) {
		try {
			UnityEngine.Joint2D self=(UnityEngine.Joint2D)checkSelf(l);
			pushValue(l,self.connectedBody);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_connectedBody(IntPtr l) {
		try {
			UnityEngine.Joint2D self=(UnityEngine.Joint2D)checkSelf(l);
			UnityEngine.Rigidbody2D v;
			checkType(l,2,out v);
			self.connectedBody=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collideConnected(IntPtr l) {
		try {
			UnityEngine.Joint2D self=(UnityEngine.Joint2D)checkSelf(l);
			pushValue(l,self.collideConnected);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collideConnected(IntPtr l) {
		try {
			UnityEngine.Joint2D self=(UnityEngine.Joint2D)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.collideConnected=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Joint2D");
		addMember(l,"connectedBody",get_connectedBody,set_connectedBody,true);
		addMember(l,"collideConnected",get_collideConnected,set_collideConnected,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Joint2D),typeof(UnityEngine.Behaviour));
	}
}
