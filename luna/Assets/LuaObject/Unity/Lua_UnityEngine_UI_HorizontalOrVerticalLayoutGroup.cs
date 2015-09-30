﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_spacing(IntPtr l) {
		try {
			UnityEngine.UI.HorizontalOrVerticalLayoutGroup self=(UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
			pushValue(l,self.spacing);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_spacing(IntPtr l) {
		try {
			UnityEngine.UI.HorizontalOrVerticalLayoutGroup self=(UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.spacing=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childForceExpandWidth(IntPtr l) {
		try {
			UnityEngine.UI.HorizontalOrVerticalLayoutGroup self=(UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
			pushValue(l,self.childForceExpandWidth);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childForceExpandWidth(IntPtr l) {
		try {
			UnityEngine.UI.HorizontalOrVerticalLayoutGroup self=(UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.childForceExpandWidth=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_childForceExpandHeight(IntPtr l) {
		try {
			UnityEngine.UI.HorizontalOrVerticalLayoutGroup self=(UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
			pushValue(l,self.childForceExpandHeight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_childForceExpandHeight(IntPtr l) {
		try {
			UnityEngine.UI.HorizontalOrVerticalLayoutGroup self=(UnityEngine.UI.HorizontalOrVerticalLayoutGroup)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.childForceExpandHeight=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.HorizontalOrVerticalLayoutGroup");
		addMember(l,"spacing",get_spacing,set_spacing,true);
		addMember(l,"childForceExpandWidth",get_childForceExpandWidth,set_childForceExpandWidth,true);
		addMember(l,"childForceExpandHeight",get_childForceExpandHeight,set_childForceExpandHeight,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup),typeof(UnityEngine.UI.LayoutGroup));
	}
}
