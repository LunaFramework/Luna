using UnityEngine;
using System.Collections;
using SLua;

public class test : MonoBehaviour {
	LuaSvr svr;
	LuaTable self;
	LuaFunction update;

	void Start () {
		svr = new LuaSvr();
		self=(LuaTable)svr.start("test/test");
		//update = (LuaFunction)self["update"];
	}
	
	void Update () {
		//update.call(self);
	}
}