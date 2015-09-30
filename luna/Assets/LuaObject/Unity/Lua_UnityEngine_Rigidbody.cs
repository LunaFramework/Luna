﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rigidbody : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rigidbody o;
			o=new UnityEngine.Rigidbody();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetDensity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.SetDensity(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddForce(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.AddForce(a1);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode a2;
				checkEnum(l,3,out a2);
				self.AddForce(a1,a2);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddForce(a1,a2,a3);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkEnum(l,5,out a4);
				self.AddForce(a1,a2,a3,a4);
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
	static public int AddRelativeForce(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.AddRelativeForce(a1);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode a2;
				checkEnum(l,3,out a2);
				self.AddRelativeForce(a1,a2);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddRelativeForce(a1,a2,a3);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkEnum(l,5,out a4);
				self.AddRelativeForce(a1,a2,a3,a4);
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
	static public int AddTorque(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.AddTorque(a1);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode a2;
				checkEnum(l,3,out a2);
				self.AddTorque(a1,a2);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddTorque(a1,a2,a3);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkEnum(l,5,out a4);
				self.AddTorque(a1,a2,a3,a4);
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
	static public int AddRelativeTorque(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				self.AddRelativeTorque(a1);
				return 0;
			}
			else if(argc==3){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.ForceMode a2;
				checkEnum(l,3,out a2);
				self.AddRelativeTorque(a1,a2);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddRelativeTorque(a1,a2,a3);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				UnityEngine.ForceMode a4;
				checkEnum(l,5,out a4);
				self.AddRelativeTorque(a1,a2,a3,a4);
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
	static public int AddForceAtPosition(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				self.AddForceAtPosition(a1,a2);
				return 0;
			}
			else if(argc==4){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				UnityEngine.ForceMode a3;
				checkEnum(l,4,out a3);
				self.AddForceAtPosition(a1,a2,a3);
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
	static public int AddExplosionForce(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				self.AddExplosionForce(a1,a2,a3);
				return 0;
			}
			else if(argc==5){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.AddExplosionForce(a1,a2,a3,a4);
				return 0;
			}
			else if(argc==6){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				UnityEngine.Vector3 a2;
				checkType(l,3,out a2);
				System.Single a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				UnityEngine.ForceMode a5;
				checkEnum(l,6,out a5);
				self.AddExplosionForce(a1,a2,a3,a4,a5);
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
	static public int ClosestPointOnBounds(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.ClosestPointOnBounds(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetRelativePointVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.GetRelativePointVelocity(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPointVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			var ret=self.GetPointVelocity(a1);
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MovePosition(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 a1;
			checkType(l,2,out a1);
			self.MovePosition(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int MoveRotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Quaternion a1;
			checkType(l,2,out a1);
			self.MoveRotation(a1);
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Sleep(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			self.Sleep();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int IsSleeping(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			var ret=self.IsSleeping();
			pushValue(l,ret);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int WakeUp(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			self.WakeUp();
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SweepTest(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.RaycastHit a2;
				var ret=self.SweepTest(a1,out a2);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
			}
			else if(argc==4){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				UnityEngine.RaycastHit a2;
				System.Single a3;
				checkType(l,4,out a3);
				var ret=self.SweepTest(a1,out a2,a3);
				pushValue(l,ret);
				pushValue(l,a2);
				return 2;
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
	static public int SweepTestAll(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				var ret=self.SweepTestAll(a1);
				pushValue(l,ret);
				return 1;
			}
			else if(argc==3){
				UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
				UnityEngine.Vector3 a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				var ret=self.SweepTestAll(a1,a2);
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
	static public int get_velocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.velocity);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_velocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.velocity=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.angularVelocity);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.angularVelocity=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_drag(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.drag);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_drag(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.drag=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_angularDrag(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.angularDrag);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_angularDrag(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.angularDrag=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mass(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.mass);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mass(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.mass=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useGravity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.useGravity);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useGravity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useGravity=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isKinematic(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.isKinematic);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isKinematic(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.isKinematic=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_freezeRotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.freezeRotation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_freezeRotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.freezeRotation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_constraints(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushEnum(l,(int)self.constraints);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_constraints(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.RigidbodyConstraints v;
			checkEnum(l,2,out v);
			self.constraints=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_collisionDetectionMode(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushEnum(l,(int)self.collisionDetectionMode);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_collisionDetectionMode(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.CollisionDetectionMode v;
			checkEnum(l,2,out v);
			self.collisionDetectionMode=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_centerOfMass(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.centerOfMass);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_centerOfMass(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.centerOfMass=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_worldCenterOfMass(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.worldCenterOfMass);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inertiaTensorRotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.inertiaTensorRotation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inertiaTensorRotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.inertiaTensorRotation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_inertiaTensor(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.inertiaTensor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_inertiaTensor(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.inertiaTensor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_detectCollisions(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.detectCollisions);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_detectCollisions(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.detectCollisions=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_useConeFriction(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.useConeFriction);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_useConeFriction(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.useConeFriction=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_position(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.position);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_position(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.position=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.rotation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_rotation(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.Quaternion v;
			checkType(l,2,out v);
			self.rotation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_interpolation(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushEnum(l,(int)self.interpolation);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_interpolation(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			UnityEngine.RigidbodyInterpolation v;
			checkEnum(l,2,out v);
			self.interpolation=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_solverIterationCount(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.solverIterationCount);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_solverIterationCount(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.solverIterationCount=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.sleepVelocity);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.sleepVelocity=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sleepAngularVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.sleepAngularVelocity);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sleepAngularVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.sleepAngularVelocity=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxAngularVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			pushValue(l,self.maxAngularVelocity);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxAngularVelocity(IntPtr l) {
		try {
			UnityEngine.Rigidbody self=(UnityEngine.Rigidbody)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxAngularVelocity=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rigidbody");
		addMember(l,SetDensity);
		addMember(l,AddForce);
		addMember(l,AddRelativeForce);
		addMember(l,AddTorque);
		addMember(l,AddRelativeTorque);
		addMember(l,AddForceAtPosition);
		addMember(l,AddExplosionForce);
		addMember(l,ClosestPointOnBounds);
		addMember(l,GetRelativePointVelocity);
		addMember(l,GetPointVelocity);
		addMember(l,MovePosition);
		addMember(l,MoveRotation);
		addMember(l,Sleep);
		addMember(l,IsSleeping);
		addMember(l,WakeUp);
		addMember(l,SweepTest);
		addMember(l,SweepTestAll);
		addMember(l,"velocity",get_velocity,set_velocity,true);
		addMember(l,"angularVelocity",get_angularVelocity,set_angularVelocity,true);
		addMember(l,"drag",get_drag,set_drag,true);
		addMember(l,"angularDrag",get_angularDrag,set_angularDrag,true);
		addMember(l,"mass",get_mass,set_mass,true);
		addMember(l,"useGravity",get_useGravity,set_useGravity,true);
		addMember(l,"isKinematic",get_isKinematic,set_isKinematic,true);
		addMember(l,"freezeRotation",get_freezeRotation,set_freezeRotation,true);
		addMember(l,"constraints",get_constraints,set_constraints,true);
		addMember(l,"collisionDetectionMode",get_collisionDetectionMode,set_collisionDetectionMode,true);
		addMember(l,"centerOfMass",get_centerOfMass,set_centerOfMass,true);
		addMember(l,"worldCenterOfMass",get_worldCenterOfMass,null,true);
		addMember(l,"inertiaTensorRotation",get_inertiaTensorRotation,set_inertiaTensorRotation,true);
		addMember(l,"inertiaTensor",get_inertiaTensor,set_inertiaTensor,true);
		addMember(l,"detectCollisions",get_detectCollisions,set_detectCollisions,true);
		addMember(l,"useConeFriction",get_useConeFriction,set_useConeFriction,true);
		addMember(l,"position",get_position,set_position,true);
		addMember(l,"rotation",get_rotation,set_rotation,true);
		addMember(l,"interpolation",get_interpolation,set_interpolation,true);
		addMember(l,"solverIterationCount",get_solverIterationCount,set_solverIterationCount,true);
		addMember(l,"sleepVelocity",get_sleepVelocity,set_sleepVelocity,true);
		addMember(l,"sleepAngularVelocity",get_sleepAngularVelocity,set_sleepAngularVelocity,true);
		addMember(l,"maxAngularVelocity",get_maxAngularVelocity,set_maxAngularVelocity,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rigidbody),typeof(UnityEngine.Component));
	}
}
