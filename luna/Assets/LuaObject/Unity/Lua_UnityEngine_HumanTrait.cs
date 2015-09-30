﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HumanTrait : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.HumanTrait o;
			o=new UnityEngine.HumanTrait();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MuscleFromBone_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			System.Int32 a2;
			checkType(l,2,out a2);
			var ret=UnityEngine.HumanTrait.MuscleFromBone(a1,a2);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int BoneFromMuscle_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.HumanTrait.BoneFromMuscle(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RequiredBone_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.HumanTrait.RequiredBone(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMuscleDefaultMin_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.HumanTrait.GetMuscleDefaultMin(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMuscleDefaultMax_s(IntPtr l) {
		try {
			System.Int32 a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.HumanTrait.GetMuscleDefaultMax(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_MuscleCount(IntPtr l) {
		try {
			pushValue(l,UnityEngine.HumanTrait.MuscleCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_MuscleName(IntPtr l) {
		try {
			pushValue(l,UnityEngine.HumanTrait.MuscleName);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_BoneCount(IntPtr l) {
		try {
			pushValue(l,UnityEngine.HumanTrait.BoneCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_BoneName(IntPtr l) {
		try {
			pushValue(l,UnityEngine.HumanTrait.BoneName);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_RequiredBoneCount(IntPtr l) {
		try {
			pushValue(l,UnityEngine.HumanTrait.RequiredBoneCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.HumanTrait");
		addMember(l,MuscleFromBone_s);
		addMember(l,BoneFromMuscle_s);
		addMember(l,RequiredBone_s);
		addMember(l,GetMuscleDefaultMin_s);
		addMember(l,GetMuscleDefaultMax_s);
		addMember(l,"MuscleCount",get_MuscleCount,null,false);
		addMember(l,"MuscleName",get_MuscleName,null,false);
		addMember(l,"BoneCount",get_BoneCount,null,false);
		addMember(l,"BoneName",get_BoneName,null,false);
		addMember(l,"RequiredBoneCount",get_RequiredBoneCount,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.HumanTrait),typeof(UnityEngine.Object));
	}
}
