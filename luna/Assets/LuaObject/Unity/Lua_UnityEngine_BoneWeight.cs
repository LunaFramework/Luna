﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_BoneWeight : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.BoneWeight o;
			o=new UnityEngine.BoneWeight();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Equality(IntPtr l) {
		try {
			UnityEngine.BoneWeight a1;
			checkType(l,1,out a1);
			UnityEngine.BoneWeight a2;
			checkType(l,2,out a2);
			var ret=(a1==a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int op_Inequality(IntPtr l) {
		try {
			UnityEngine.BoneWeight a1;
			checkType(l,1,out a1);
			UnityEngine.BoneWeight a2;
			checkType(l,2,out a2);
			var ret=(a1!=a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight0(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			pushValue(l,self.weight0);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight0(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.weight0=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight1(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			pushValue(l,self.weight1);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight1(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.weight1=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight2(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			pushValue(l,self.weight2);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight2(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.weight2=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight3(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			pushValue(l,self.weight3);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_weight3(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.weight3=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneIndex0(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			pushValue(l,self.boneIndex0);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneIndex0(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.boneIndex0=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneIndex1(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			pushValue(l,self.boneIndex1);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneIndex1(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.boneIndex1=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneIndex2(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			pushValue(l,self.boneIndex2);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneIndex2(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.boneIndex2=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_boneIndex3(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			pushValue(l,self.boneIndex3);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_boneIndex3(IntPtr l) {
		try {
			UnityEngine.BoneWeight self;
			checkType(l,1,out self);
			int v;
			checkType(l,2,out v);
			self.boneIndex3=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.BoneWeight");
		addMember(l,op_Equality);
		addMember(l,op_Inequality);
		addMember(l,"weight0",get_weight0,set_weight0,true);
		addMember(l,"weight1",get_weight1,set_weight1,true);
		addMember(l,"weight2",get_weight2,set_weight2,true);
		addMember(l,"weight3",get_weight3,set_weight3,true);
		addMember(l,"boneIndex0",get_boneIndex0,set_boneIndex0,true);
		addMember(l,"boneIndex1",get_boneIndex1,set_boneIndex1,true);
		addMember(l,"boneIndex2",get_boneIndex2,set_boneIndex2,true);
		addMember(l,"boneIndex3",get_boneIndex3,set_boneIndex3,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.BoneWeight),typeof(System.ValueType));
	}
}
