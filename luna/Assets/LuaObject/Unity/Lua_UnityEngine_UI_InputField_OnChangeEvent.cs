﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_InputField_OnChangeEvent : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.UI.InputField.OnChangeEvent o;
			o=new UnityEngine.UI.InputField.OnChangeEvent();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		LuaUnityEvent_string.reg(l);
		getTypeTable(l,"UnityEngine.UI.InputField.OnChangeEvent");
		createTypeMetatable(l,constructor, typeof(UnityEngine.UI.InputField.OnChangeEvent),typeof(LuaUnityEvent_string));
	}
}
