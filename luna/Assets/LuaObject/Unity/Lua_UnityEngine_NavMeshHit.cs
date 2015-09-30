﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshHit : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.NavMeshHit o;
			o=new UnityEngine.NavMeshHit();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
			checkType(l,1,out self);
			pushValue(l,self.position);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
			checkType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.position=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normal(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
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
	static public int set_normal(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
			checkType(l,1,out self);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.normal=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_distance(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
			checkType(l,1,out self);
			pushValue(l,self.distance);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_distance(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.distance=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mask(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
			checkType(l,1,out self);
			pushValue(l,self.mask);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mask(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
			checkType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.mask=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hit(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
			checkType(l,1,out self);
			pushValue(l,self.hit);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hit(IntPtr l) {
		try {
			UnityEngine.NavMeshHit self;
			checkType(l,1,out self);
			bool v;
			checkType(l,2,out v);
			self.hit=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshHit");
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"normal",get_normal,set_normal,true);
		addMember(l,"distance",get_distance,set_distance,true);
		addMember(l,"mask",get_mask,set_mask,true);
		addMember(l,"hit",get_hit,set_hit,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshHit),typeof(System.ValueType));
	}
}
