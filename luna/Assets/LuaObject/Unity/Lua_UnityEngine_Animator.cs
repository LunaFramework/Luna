﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Animator : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Animator o;
			o=new UnityEngine.Animator();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetFloat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetFloat(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetFloat(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetFloat(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetFloat(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(float),typeof(float),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.SetFloat(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(float),typeof(float),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.SetFloat(a1,a2,a3,a4);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBool(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetBool(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetBool(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetBool(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(bool))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetBool(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(bool))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetBool(a1,a2);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInteger(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetInteger(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.GetInteger(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetInteger(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInteger(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetInteger(a1,a2);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTrigger(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.SetTrigger(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.SetTrigger(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ResetTrigger(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.ResetTrigger(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.ResetTrigger(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsParameterControlledByCurve(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.IsParameterControlledByCurve(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				var ret=self.IsParameterControlledByCurve(a1);
				pushValue(l,ret);
				return 1;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIKPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			var ret=self.GetIKPosition(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIKPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			self.SetIKPosition(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIKRotation(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			var ret=self.GetIKRotation(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIKRotation(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			UnityEngine.Quaternion a2;
			checkType(l,3,out a2);
			self.SetIKRotation(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIKPositionWeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			var ret=self.GetIKPositionWeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIKPositionWeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetIKPositionWeight(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetIKRotationWeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			var ret=self.GetIKRotationWeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetIKRotationWeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarIKGoal a1;
			checkEnum(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetIKRotationWeight(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLookAtPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.SetLookAtPosition(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLookAtWeight(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.SetLookAtWeight(a1);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.SetLookAtWeight(a1,a2);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.SetLookAtWeight(a1,a2,a3);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.SetLookAtWeight(a1,a2,a3,a4);
				return 0;
			}
			else if(argc==6){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				System.Single a5;
				checkType(l,6,out a5);
				self.SetLookAtWeight(a1,a2,a3,a4,a5);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLayerName(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetLayerName(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLayerWeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetLayerWeight(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetLayerWeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetLayerWeight(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetCurrentAnimatorStateInfo(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetCurrentAnimatorStateInfo(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNextAnimatorStateInfo(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetNextAnimatorStateInfo(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAnimatorTransitionInfo(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetAnimatorTransitionInfo(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetCurrentAnimationClipState(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetCurrentAnimationClipState(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNextAnimationClipState(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetNextAnimationClipState(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsInTransition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.IsInTransition(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MatchTarget(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==6){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Quaternion a2;
				checkType(l,3,out a2);
				UnityEngine.AvatarTarget a3;
				checkEnum(l,4,out a3);
				UnityEngine.MatchTargetWeightMask a4;
				checkType(l,5,out a4);
				System.Single a5;
				checkType(l,6,out a5);
				self.MatchTarget(a1,a2,a3,a4,a5);
				return 0;
			}
			else if(argc==7){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Quaternion a2;
				checkType(l,3,out a2);
				UnityEngine.AvatarTarget a3;
				checkEnum(l,4,out a3);
				UnityEngine.MatchTargetWeightMask a4;
				checkType(l,5,out a4);
				System.Single a5;
				checkType(l,6,out a5);
				System.Single a6;
				checkType(l,7,out a6);
				self.MatchTarget(a1,a2,a3,a4,a5,a6);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int InterruptMatchTarget(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				self.InterruptMatchTarget();
				return 0;
			}
			else if(argc==2){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.InterruptMatchTarget(a1);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CrossFade(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.CrossFade(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.CrossFade(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(float),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.CrossFade(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(float),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.CrossFade(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(float),typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.CrossFade(a1,a2,a3,a4);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(float),typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.CrossFade(a1,a2,a3,a4);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Play(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.Play(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.Play(a1);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.Play(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(int))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.Play(a1,a2);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(string),typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.Play(a1,a2,a3);
				return 0;
			}
			else if(matchType(l,argc,2,typeof(int),typeof(int),typeof(float))){
				UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.Play(a1,a2,a3);
				return 0;
			}
			LuaDLL.luaL_error(l,"No matched override function to call");
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTarget(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AvatarTarget a1;
			checkEnum(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.SetTarget(a1,a2);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBoneTransform(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.HumanBodyBones a1;
			checkEnum(l,2,out a1);
			var ret=self.GetBoneTransform(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StartPlayback(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			self.StartPlayback();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopPlayback(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			self.StopPlayback();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StartRecording(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.StartRecording(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StopRecording(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			self.StopRecording();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Update(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.Update(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Rebind(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			self.Rebind();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int StringToHash_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Animator.StringToHash(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isOptimizable(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.isOptimizable);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isHuman(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.isHuman);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasRootMotion(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.hasRootMotion);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_humanScale(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.humanScale);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.deltaPosition);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_deltaRotation(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.deltaRotation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rootPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.rootPosition);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rootPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.rootPosition=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rootRotation(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.rootRotation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rootRotation(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.rootRotation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_applyRootMotion(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.applyRootMotion);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_applyRootMotion(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.applyRootMotion=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_updateMode(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushEnum(l,(int)self.updateMode);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_updateMode(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AnimatorUpdateMode v;
			checkEnum(l,2,out v);
			self.updateMode=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasTransformHierarchy(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.hasTransformHierarchy);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_gravityWeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.gravityWeight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bodyPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.bodyPosition);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bodyPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.bodyPosition=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_bodyRotation(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.bodyRotation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_bodyRotation(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.bodyRotation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_stabilizeFeet(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.stabilizeFeet);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_stabilizeFeet(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.stabilizeFeet=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layerCount(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.layerCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_feetPivotActive(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.feetPivotActive);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_feetPivotActive(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.feetPivotActive=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivotWeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.pivotWeight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_pivotPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.pivotPosition);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isMatchingTarget(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.isMatchingTarget);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_speed(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.speed);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_speed(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.speed=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetPosition(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.targetPosition);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_targetRotation(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.targetRotation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cullingMode(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushEnum(l,(int)self.cullingMode);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cullingMode(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.AnimatorCullingMode v;
			checkEnum(l,2,out v);
			self.cullingMode=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_playbackTime(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.playbackTime);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_playbackTime(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.playbackTime=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_recorderStartTime(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.recorderStartTime);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_recorderStartTime(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.recorderStartTime=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_recorderStopTime(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.recorderStopTime);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_recorderStopTime(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.recorderStopTime=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_runtimeAnimatorController(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.runtimeAnimatorController);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_runtimeAnimatorController(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.RuntimeAnimatorController v;
			checkType(l,2,out v);
			self.runtimeAnimatorController=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_avatar(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.avatar);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_avatar(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			UnityEngine.Avatar v;
			checkType(l,2,out v);
			self.avatar=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_layersAffectMassCenter(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.layersAffectMassCenter);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_layersAffectMassCenter(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.layersAffectMassCenter=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_leftFeetBottomHeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.leftFeetBottomHeight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rightFeetBottomHeight(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.rightFeetBottomHeight);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_logWarnings(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.logWarnings);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_logWarnings(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.logWarnings=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_fireEvents(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			pushValue(l,self.fireEvents);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_fireEvents(IntPtr l) {
		try {
			UnityEngine.Animator self=(UnityEngine.Animator)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.fireEvents=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Animator");
		addMember(l,GetFloat);
		addMember(l,SetFloat);
		addMember(l,GetBool);
		addMember(l,SetBool);
		addMember(l,GetInteger);
		addMember(l,SetInteger);
		addMember(l,SetTrigger);
		addMember(l,ResetTrigger);
		addMember(l,IsParameterControlledByCurve);
		addMember(l,GetIKPosition);
		addMember(l,SetIKPosition);
		addMember(l,GetIKRotation);
		addMember(l,SetIKRotation);
		addMember(l,GetIKPositionWeight);
		addMember(l,SetIKPositionWeight);
		addMember(l,GetIKRotationWeight);
		addMember(l,SetIKRotationWeight);
		addMember(l,SetLookAtPosition);
		addMember(l,SetLookAtWeight);
		addMember(l,GetLayerName);
		addMember(l,GetLayerWeight);
		addMember(l,SetLayerWeight);
		addMember(l,GetCurrentAnimatorStateInfo);
		addMember(l,GetNextAnimatorStateInfo);
		addMember(l,GetAnimatorTransitionInfo);
		addMember(l,GetCurrentAnimationClipState);
		addMember(l,GetNextAnimationClipState);
		addMember(l,IsInTransition);
		addMember(l,MatchTarget);
		addMember(l,InterruptMatchTarget);
		addMember(l,CrossFade);
		addMember(l,Play);
		addMember(l,SetTarget);
		addMember(l,GetBoneTransform);
		addMember(l,StartPlayback);
		addMember(l,StopPlayback);
		addMember(l,StartRecording);
		addMember(l,StopRecording);
		addMember(l,Update);
		addMember(l,Rebind);
		addMember(l,StringToHash_s);
		addMember(l,"isOptimizable",get_isOptimizable,null,true);
		addMember(l,"isHuman",get_isHuman,null,true);
		addMember(l,"hasRootMotion",get_hasRootMotion,null,true);
		addMember(l,"humanScale",get_humanScale,null,true);
		addMember(l,"deltaPosition",get_deltaPosition,null,true);
		addMember(l,"deltaRotation",get_deltaRotation,null,true);
		addMember(l,"rootPosition",get_rootPosition,set_rootPosition,true);
		addMember(l,"rootRotation",get_rootRotation,set_rootRotation,true);
		addMember(l,"applyRootMotion",get_applyRootMotion,set_applyRootMotion,true);
		addMember(l,"updateMode",get_updateMode,set_updateMode,true);
		addMember(l,"hasTransformHierarchy",get_hasTransformHierarchy,null,true);
		addMember(l,"gravityWeight",get_gravityWeight,null,true);
		addMember(l,"bodyPosition",get_bodyPosition,set_bodyPosition,true);
		addMember(l,"bodyRotation",get_bodyRotation,set_bodyRotation,true);
		addMember(l,"stabilizeFeet",get_stabilizeFeet,set_stabilizeFeet,true);
		addMember(l,"layerCount",get_layerCount,null,true);
		addMember(l,"feetPivotActive",get_feetPivotActive,set_feetPivotActive,true);
		addMember(l,"pivotWeight",get_pivotWeight,null,true);
		addMember(l,"pivotPosition",get_pivotPosition,null,true);
		addMember(l,"isMatchingTarget",get_isMatchingTarget,null,true);
		addMember(l,"speed",get_speed,set_speed,true);
		addMember(l,"targetPosition",get_targetPosition,null,true);
		addMember(l,"targetRotation",get_targetRotation,null,true);
		addMember(l,"cullingMode",get_cullingMode,set_cullingMode,true);
		addMember(l,"playbackTime",get_playbackTime,set_playbackTime,true);
		addMember(l,"recorderStartTime",get_recorderStartTime,set_recorderStartTime,true);
		addMember(l,"recorderStopTime",get_recorderStopTime,set_recorderStopTime,true);
		addMember(l,"runtimeAnimatorController",get_runtimeAnimatorController,set_runtimeAnimatorController,true);
		addMember(l,"avatar",get_avatar,set_avatar,true);
		addMember(l,"layersAffectMassCenter",get_layersAffectMassCenter,set_layersAffectMassCenter,true);
		addMember(l,"leftFeetBottomHeight",get_leftFeetBottomHeight,null,true);
		addMember(l,"rightFeetBottomHeight",get_rightFeetBottomHeight,null,true);
		addMember(l,"logWarnings",get_logWarnings,set_logWarnings,true);
		addMember(l,"fireEvents",get_fireEvents,set_fireEvents,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Animator),typeof(UnityEngine.Behaviour));
	}
}
