﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_JointAngleLimits2D : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.JointAngleLimits2D o;
			o=new UnityEngine.JointAngleLimits2D();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_min(IntPtr l) {
		try {
			UnityEngine.JointAngleLimits2D self;
			checkType(l,1,out self);
			pushValue(l,self.min);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_min(IntPtr l) {
		try {
			UnityEngine.JointAngleLimits2D self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.min=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_max(IntPtr l) {
		try {
			UnityEngine.JointAngleLimits2D self;
			checkType(l,1,out self);
			pushValue(l,self.max);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_max(IntPtr l) {
		try {
			UnityEngine.JointAngleLimits2D self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.max=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.JointAngleLimits2D");
		addMember(l,"min",get_min,set_min,true);
		addMember(l,"max",get_max,set_max,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.JointAngleLimits2D),typeof(System.ValueType));
	}
}
