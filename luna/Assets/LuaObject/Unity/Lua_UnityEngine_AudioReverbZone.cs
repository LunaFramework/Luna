﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AudioReverbZone : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone o;
			o=new UnityEngine.AudioReverbZone();
			pushValue(l,o);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_minDistance(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.minDistance);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_minDistance(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.minDistance=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_maxDistance(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.maxDistance);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_maxDistance(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.maxDistance=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbPreset(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushEnum(l,(int)self.reverbPreset);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbPreset(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			UnityEngine.AudioReverbPreset v;
			checkEnum(l,2,out v);
			self.reverbPreset=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_room(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.room);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_room(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.room=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomHF(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.roomHF);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomHF(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.roomHF=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomLF(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.roomLF);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomLF(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.roomLF=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decayTime(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.decayTime);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decayTime(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.decayTime=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_decayHFRatio(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.decayHFRatio);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_decayHFRatio(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.decayHFRatio=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reflections(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.reflections);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reflections(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.reflections=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reflectionsDelay(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.reflectionsDelay);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reflectionsDelay(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.reflectionsDelay=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverb(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.reverb);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverb(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.reverb=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_reverbDelay(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.reverbDelay);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_reverbDelay(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.reverbDelay=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_HFReference(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.HFReference);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_HFReference(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.HFReference=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_LFReference(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.LFReference);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_LFReference(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.LFReference=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_roomRolloffFactor(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.roomRolloffFactor);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_roomRolloffFactor(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.roomRolloffFactor=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_diffusion(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.diffusion);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_diffusion(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.diffusion=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_density(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			pushValue(l,self.density);
			return 1;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_density(IntPtr l) {
		try {
			UnityEngine.AudioReverbZone self=(UnityEngine.AudioReverbZone)checkSelf(l);
			float v;
			checkType(l,2,out v);
			self.density=v;
			return 0;
		}
		catch(Exception e) {
			LuaDLL.luaL_error(l, e.ToString());
			return 0;
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AudioReverbZone");
		addMember(l,"minDistance",get_minDistance,set_minDistance,true);
		addMember(l,"maxDistance",get_maxDistance,set_maxDistance,true);
		addMember(l,"reverbPreset",get_reverbPreset,set_reverbPreset,true);
		addMember(l,"room",get_room,set_room,true);
		addMember(l,"roomHF",get_roomHF,set_roomHF,true);
		addMember(l,"roomLF",get_roomLF,set_roomLF,true);
		addMember(l,"decayTime",get_decayTime,set_decayTime,true);
		addMember(l,"decayHFRatio",get_decayHFRatio,set_decayHFRatio,true);
		addMember(l,"reflections",get_reflections,set_reflections,true);
		addMember(l,"reflectionsDelay",get_reflectionsDelay,set_reflectionsDelay,true);
		addMember(l,"reverb",get_reverb,set_reverb,true);
		addMember(l,"reverbDelay",get_reverbDelay,set_reverbDelay,true);
		addMember(l,"HFReference",get_HFReference,set_HFReference,true);
		addMember(l,"LFReference",get_LFReference,set_LFReference,true);
		addMember(l,"roomRolloffFactor",get_roomRolloffFactor,set_roomRolloffFactor,true);
		addMember(l,"diffusion",get_diffusion,set_diffusion,true);
		addMember(l,"density",get_density,set_density,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AudioReverbZone),typeof(UnityEngine.Behaviour));
	}
}
