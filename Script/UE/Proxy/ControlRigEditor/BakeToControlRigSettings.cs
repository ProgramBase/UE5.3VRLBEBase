using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.BakeToControlRigSettings")]
	public partial class UBakeToControlRigSettings : UObject, IStaticClass
	{
		public bool bReduceKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReduceKeys, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReduceKeys, __InBuffer);
				}
			}
		}

		public float Tolerance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Tolerance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Tolerance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.BakeToControlRigSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bReduceKeys = 0;

		private static uint __Tolerance = 0;
	}
}