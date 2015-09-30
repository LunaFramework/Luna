﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimationEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AnimationEvent o;
			o=new UnityEngine.AnimationEvent();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stringParameter(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			pushValue(l,self.stringParameter);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stringParameter(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.stringParameter=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_floatParameter(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			pushValue(l,self.floatParameter);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_floatParameter(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.floatParameter=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_intParameter(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			pushValue(l,self.intParameter);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_intParameter(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.intParameter=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_objectReferenceParameter(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			pushValue(l,self.objectReferenceParameter);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_objectReferenceParameter(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			UnityEngine.Object v;
			checkType(l,2,out v);
			self.objectReferenceParameter=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_functionName(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			pushValue(l,self.functionName);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_functionName(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.functionName=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_time(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			pushValue(l,self.time);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_time(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.time=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_messageOptions(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			pushEnum(l,(int)self.messageOptions);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_messageOptions(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			UnityEngine.SendMessageOptions v;
			checkEnum(l,2,out v);
			self.messageOptions=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_animationState(IntPtr l) {
		try {
			UnityEngine.AnimationEvent self=(UnityEngine.AnimationEvent)checkSelf(l);
			pushValue(l,self.animationState);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimationEvent");
		addMember(l,"stringParameter",get_stringParameter,set_stringParameter,true);
		addMember(l,"floatParameter",get_floatParameter,set_floatParameter,true);
		addMember(l,"intParameter",get_intParameter,set_intParameter,true);
		addMember(l,"objectReferenceParameter",get_objectReferenceParameter,set_objectReferenceParameter,true);
		addMember(l,"functionName",get_functionName,set_functionName,true);
		addMember(l,"time",get_time,set_time,true);
		addMember(l,"messageOptions",get_messageOptions,set_messageOptions,true);
		addMember(l,"animationState",get_animationState,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimationEvent));
	}
}
