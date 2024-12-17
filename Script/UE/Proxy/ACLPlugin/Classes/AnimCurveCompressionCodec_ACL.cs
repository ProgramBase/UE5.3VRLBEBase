using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ACLPlugin
{
	[PathName("/Script/ACLPlugin.AnimCurveCompressionCodec_ACL")]
	public partial class UAnimCurveCompressionCodec_ACL : UAnimCurveCompressionCodec, IStaticClass
	{
		public float CurvePrecision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurvePrecision, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurvePrecision, __InBuffer);
				}
			}
		}

		public float MorphTargetPositionPrecision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MorphTargetPositionPrecision, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MorphTargetPositionPrecision, __InBuffer);
				}
			}
		}

		public USkeletalMesh MorphTargetSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MorphTargetSource, __ReturnBuffer);

					return *(USkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MorphTargetSource, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ACLPlugin.AnimCurveCompressionCodec_ACL");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CurvePrecision = 0;

		private static uint __MorphTargetPositionPrecision = 0;

		private static uint __MorphTargetSource = 0;
	}
}