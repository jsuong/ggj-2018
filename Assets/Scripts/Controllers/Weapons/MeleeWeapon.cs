﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace boc {
	public class MeleeWeapon : MonoBehaviour {
		[SerializeField]
		private float damage;

		public bool IsActive { get; set; }

		private void OnTriggerEnter (Collider c) {
			var hp = c.GetComponentInParent<IHealth> ();

			if (hp != null) {
				hp.Damage (damage);
				IsActive = false;
			}
		}
	}
}