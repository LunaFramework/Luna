﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_ColorBlock : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock o;
			o=new UnityEngine.UI.ColorBlock();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_normalColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			pushValue(l,self.normalColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_normalColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.normalColor=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_highlightedColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			pushValue(l,self.highlightedColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_highlightedColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.highlightedColor=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pressedColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			pushValue(l,self.pressedColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_pressedColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.pressedColor=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_disabledColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			pushValue(l,self.disabledColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_disabledColor(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.disabledColor=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorMultiplier(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			pushValue(l,self.colorMultiplier);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colorMultiplier(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.colorMultiplier=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fadeDuration(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			pushValue(l,self.fadeDuration);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fadeDuration(IntPtr l) {
		try {
			UnityEngine.UI.ColorBlock self;
			checkType(l,1,out self);
			float v;
			checkType(l,2,out v);
			self.fadeDuration=v;
			setBack(l,self);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_defaultColorBlock(IntPtr l) {
		try {
			pushValue(l,UnityEngine.UI.ColorBlock.defaultColorBlock);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.ColorBlock");
		addMember(l,"normalColor",get_normalColor,set_normalColor,true);
		addMember(l,"highlightedColor",get_highlightedColor,set_highlightedColor,true);
		addMember(l,"pressedColor",get_pressedColor,set_pressedColor,true);
		addMember(l,"disabledColor",get_disabledColor,set_disabledColor,true);
		addMember(l,"colorMultiplier",get_colorMultiplier,set_colorMultiplier,true);
		addMember(l,"fadeDuration",get_fadeDuration,set_fadeDuration,true);
		addMember(l,"defaultColorBlock",get_defaultColorBlock,null,false);
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.ColorBlock),typeof(System.ValueType));
	}
}
