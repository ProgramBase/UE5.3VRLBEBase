﻿using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigBoolControlProxy")]
	public partial class UControlRigBoolControlProxy : UControlRigControlsProxy, IStaticClass
	{
		public bool Bool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Bool, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Bool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigBoolControlProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Bool = 0;
	}
}