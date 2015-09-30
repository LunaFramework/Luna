﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_WheelCollider : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.WheelCollider o;
			o=new UnityEngine.WheelCollider();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetGroundHit(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			UnityEngine.WheelHit a1;
			var ret=self.GetGroundHit(out a1);
			pushValue(l,ret);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_center(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.center);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_center(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			UnityEngine.Vector3 v;
			checkType(l,2,out v);
			self.center=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_radius(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.radius);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_radius(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.radius=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_suspensionDistance(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.suspensionDistance);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_suspensionDistance(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.suspensionDistance=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_suspensionSpring(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.suspensionSpring);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_suspensionSpring(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			UnityEngine.JointSpring v;
			checkType(l,2,out v);
			self.suspensionSpring=v;
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
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
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
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
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
	static public int get_forwardFriction(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.forwardFriction);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_forwardFriction(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			UnityEngine.WheelFrictionCurve v;
			checkType(l,2,out v);
			self.forwardFriction=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_sidewaysFriction(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.sidewaysFriction);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_sidewaysFriction(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			UnityEngine.WheelFrictionCurve v;
			checkType(l,2,out v);
			self.sidewaysFriction=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_motorTorque(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.motorTorque);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_motorTorque(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.motorTorque=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_brakeTorque(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.brakeTorque);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_brakeTorque(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.brakeTorque=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_steerAngle(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.steerAngle);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_steerAngle(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.steerAngle=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isGrounded(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.isGrounded);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_rpm(IntPtr l) {
		try {
			UnityEngine.WheelCollider self=(UnityEngine.WheelCollider)checkSelf(l);
			pushValue(l,self.rpm);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.WheelCollider");
		addMember(l,GetGroundHit);
		addMember(l,"center",get_center,set_center,true);
		addMember(l,"radius",get_radius,set_radius,true);
		addMember(l,"suspensionDistance",get_suspensionDistance,set_suspensionDistance,true);
		addMember(l,"suspensionSpring",get_suspensionSpring,set_suspensionSpring,true);
		addMember(l,"mass",get_mass,set_mass,true);
		addMember(l,"forwardFriction",get_forwardFriction,set_forwardFriction,true);
		addMember(l,"sidewaysFriction",get_sidewaysFriction,set_sidewaysFriction,true);
		addMember(l,"motorTorque",get_motorTorque,set_motorTorque,true);
		addMember(l,"brakeTorque",get_brakeTorque,set_brakeTorque,true);
		addMember(l,"steerAngle",get_steerAngle,set_steerAngle,true);
		addMember(l,"isGrounded",get_isGrounded,null,true);
		addMember(l,"rpm",get_rpm,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.WheelCollider),typeof(UnityEngine.Collider));
	}
}
