using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActiveCameraShakeInfo")]
	public partial class FActiveCameraShakeInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActiveCameraShakeInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActiveCameraShakeInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActiveCameraShakeInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActiveCameraShakeInfo A, FActiveCameraShakeInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActiveCameraShakeInfo A, FActiveCameraShakeInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActiveCameraShakeInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UCameraShakeBase ShakeInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShakeInstance, __ReturnBuffer);

					return *(UCameraShakeBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShakeInstance, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UCameraShakeSourceComponent> ShakeSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShakeSource, __ReturnBuffer);

					return *(TWeakObjectPtr<UCameraShakeSourceComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShakeSource, __InBuffer);
				}
			}
		}

		public bool bIsCustomInitialized
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsCustomInitialized, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsCustomInitialized, __InBuffer);
				}
			}
		}

		private static uint __ShakeInstance = 0;

		private static uint __ShakeSource = 0;

		private static uint __bIsCustomInitialized = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}