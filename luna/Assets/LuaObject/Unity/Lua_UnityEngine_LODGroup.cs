﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LODGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.LODGroup o;
			o=new UnityEngine.LODGroup();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RecalculateBounds(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			self.RecalculateBounds();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLODS(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			UnityEngine.LOD[] a1;
			checkType(l,2,out a1);
			self.SetLODS(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ForceLOD(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.ForceLOD(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_localReferencePoint(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			pushValue(l,self.localReferencePoint);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_localReferencePoint(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.localReferencePoint=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_size(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			pushValue(l,self.size);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_size(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.size=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lodCount(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			pushValue(l,self.lodCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_enabled(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			pushValue(l,self.enabled);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_enabled(IntPtr l) {
		try {
			UnityEngine.LODGroup self=(UnityEngine.LODGroup)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.enabled=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.LODGroup");
		addMember(l,RecalculateBounds);
		addMember(l,SetLODS);
		addMember(l,ForceLOD);
		addMember(l,"localReferencePoint",get_localReferencePoint,set_localReferencePoint,true);
		addMember(l,"size",get_size,set_size,true);
		addMember(l,"lodCount",get_lodCount,null,true);
		addMember(l,"enabled",get_enabled,set_enabled,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.LODGroup),typeof(UnityEngine.Component));
	}
}
