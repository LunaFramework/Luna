﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_NavMeshTriangulation : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation o;
			o=new UnityEngine.NavMeshTriangulation();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_vertices(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkType(l,1,out self);
			pushValue(l,self.vertices);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_vertices(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkType(l,1,out self);
			UnityEngine.Vector3[] v;
			checkType(l,2,out v);
			self.vertices=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_indices(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkType(l,1,out self);
			pushValue(l,self.indices);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_indices(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkType(l,1,out self);
			System.Int32[] v;
			checkType(l,2,out v);
			self.indices=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layers(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkType(l,1,out self);
			pushValue(l,self.layers);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layers(IntPtr l) {
		try {
			UnityEngine.NavMeshTriangulation self;
			checkType(l,1,out self);
			System.Int32[] v;
			checkType(l,2,out v);
			self.layers=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.NavMeshTriangulation");
		addMember(l,"vertices",get_vertices,set_vertices,true);
		addMember(l,"indices",get_indices,set_indices,true);
		addMember(l,"layers",get_layers,set_layers,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.NavMeshTriangulation),typeof(System.ValueType));
	}
}
