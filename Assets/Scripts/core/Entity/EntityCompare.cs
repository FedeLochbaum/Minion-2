using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityCompare : IComparer<Entity>{
	int IComparer<Entity>.Compare(Entity obj1, Entity obj2) {
		float t1 = obj1.actionSpeed ();
		float t2 = obj2.actionSpeed ();
		return t1.CompareTo(t2);
	}
}