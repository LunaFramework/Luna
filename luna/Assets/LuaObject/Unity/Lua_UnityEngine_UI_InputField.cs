﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_UI_InputField : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveTextEnd(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.MoveTextEnd(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveTextStart(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.MoveTextStart(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ScreenToLocal(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.Vector2 a1;
			checkType(l,2,out a1);
			var ret=self.ScreenToLocal(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnBeginDrag(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnBeginDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDrag(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnEndDrag(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnEndDrag(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerDown(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerDown(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ProcessEvent(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.Event a1;
			checkType(l,2,out a1);
			self.ProcessEvent(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnUpdateSelected(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnUpdateSelected(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebuild(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.CanvasUpdate a1;
			checkEnum(l,2,out a1);
			self.Rebuild(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ActivateInputField(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			self.ActivateInputField();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSelect(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnSelect(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerClick(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerClick(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DeactivateInputField(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			self.DeactivateInputField();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDeselect(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnDeselect(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnSubmit(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.EventSystems.BaseEventData a1;
			checkType(l,2,out a1);
			self.OnSubmit(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_shouldHideMobileInput(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.shouldHideMobileInput);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_shouldHideMobileInput(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.shouldHideMobileInput=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.text);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.text=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isFocused(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.isFocused);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_caretBlinkRate(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.caretBlinkRate);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_caretBlinkRate(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.caretBlinkRate=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_textComponent(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.textComponent);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_textComponent(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.Text v;
			checkType(l,2,out v);
			self.textComponent=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_placeholder(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.placeholder);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_placeholder(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.Graphic v;
			checkType(l,2,out v);
			self.placeholder=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_selectionColor(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.selectionColor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_selectionColor(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.Color v;
			checkType(l,2,out v);
			self.selectionColor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onEndEdit(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.onEndEdit);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onEndEdit(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.InputField.SubmitEvent v;
			checkType(l,2,out v);
			self.onEndEdit=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_onValueChange(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.onValueChange);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValueChange(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.InputField.OnChangeEvent v;
			checkType(l,2,out v);
			self.onValueChange=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onValidateInput(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.InputField.OnValidateInput v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onValidateInput=v;
			else if(op==1) self.onValidateInput+=v;
			else if(op==2) self.onValidateInput-=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterLimit(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.characterLimit);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterLimit(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.characterLimit=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_contentType(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushEnum(l,(int)self.contentType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_contentType(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.InputField.ContentType v;
			checkEnum(l,2,out v);
			self.contentType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_lineType(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushEnum(l,(int)self.lineType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_lineType(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.InputField.LineType v;
			checkEnum(l,2,out v);
			self.lineType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inputType(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushEnum(l,(int)self.inputType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inputType(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.InputField.InputType v;
			checkEnum(l,2,out v);
			self.inputType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_keyboardType(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushEnum(l,(int)self.keyboardType);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_keyboardType(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.TouchScreenKeyboardType v;
			checkEnum(l,2,out v);
			self.keyboardType=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_characterValidation(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushEnum(l,(int)self.characterValidation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_characterValidation(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			UnityEngine.UI.InputField.CharacterValidation v;
			checkEnum(l,2,out v);
			self.characterValidation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_multiLine(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.multiLine);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_asteriskChar(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.asteriskChar);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_asteriskChar(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			System.Char v;
			checkType(l,2,out v);
			self.asteriskChar=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_wasCanceled(IntPtr l) {
		try {
			UnityEngine.UI.InputField self=(UnityEngine.UI.InputField)checkSelf(l);
			pushValue(l,self.wasCanceled);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.UI.InputField");
		addMember(l,MoveTextEnd);
		addMember(l,MoveTextStart);
		addMember(l,ScreenToLocal);
		addMember(l,OnBeginDrag);
		addMember(l,OnDrag);
		addMember(l,OnEndDrag);
		addMember(l,OnPointerDown);
		addMember(l,ProcessEvent);
		addMember(l,OnUpdateSelected);
		addMember(l,Rebuild);
		addMember(l,ActivateInputField);
		addMember(l,OnSelect);
		addMember(l,OnPointerClick);
		addMember(l,DeactivateInputField);
		addMember(l,OnDeselect);
		addMember(l,OnSubmit);
		addMember(l,"shouldHideMobileInput",get_shouldHideMobileInput,set_shouldHideMobileInput,true);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"isFocused",get_isFocused,null,true);
		addMember(l,"caretBlinkRate",get_caretBlinkRate,set_caretBlinkRate,true);
		addMember(l,"textComponent",get_textComponent,set_textComponent,true);
		addMember(l,"placeholder",get_placeholder,set_placeholder,true);
		addMember(l,"selectionColor",get_selectionColor,set_selectionColor,true);
		addMember(l,"onEndEdit",get_onEndEdit,set_onEndEdit,true);
		addMember(l,"onValueChange",get_onValueChange,set_onValueChange,true);
		addMember(l,"onValidateInput",null,set_onValidateInput,true);
		addMember(l,"characterLimit",get_characterLimit,set_characterLimit,true);
		addMember(l,"contentType",get_contentType,set_contentType,true);
		addMember(l,"lineType",get_lineType,set_lineType,true);
		addMember(l,"inputType",get_inputType,set_inputType,true);
		addMember(l,"keyboardType",get_keyboardType,set_keyboardType,true);
		addMember(l,"characterValidation",get_characterValidation,set_characterValidation,true);
		addMember(l,"multiLine",get_multiLine,null,true);
		addMember(l,"asteriskChar",get_asteriskChar,set_asteriskChar,true);
		addMember(l,"wasCanceled",get_wasCanceled,null,true);
		createTypeMetatable(l,null, typeof(UnityEngine.UI.InputField),typeof(UnityEngine.UI.Selectable));
	}
}
