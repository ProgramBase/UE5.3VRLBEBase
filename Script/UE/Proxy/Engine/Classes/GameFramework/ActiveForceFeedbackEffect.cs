using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActiveForceFeedbackEffect")]
	public partial class FActiveForceFeedbackEffect : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActiveForceFeedbackEffect");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActiveForceFeedbackEffect() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActiveForceFeedbackEffect() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActiveForceFeedbackEffect A, FActiveForceFeedbackEffect B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActiveForceFeedbackEffect A, FActiveForceFeedbackEffect B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActiveForceFeedbackEffect;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UForceFeedbackEffect ForceFeedbackEffect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ForceFeedbackEffect, __ReturnBuffer);

					return *(UForceFeedbackEffect*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ForceFeedbackEffect, __InBuffer);
				}
			}
		}

		public TSet<FInputDevicePropertyHandle> ActiveDeviceProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveDeviceProperties, __ReturnBuffer);

					return *(TSet<FInputDevicePropertyHandle>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveDeviceProperties, __InBuffer);
				}
			}
		}

		private static uint __ForceFeedbackEffect = 0;

		private static uint __ActiveDeviceProperties = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}