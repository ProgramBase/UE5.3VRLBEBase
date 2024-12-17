using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LinkedAnimLayerInstanceData")]
	public partial class FLinkedAnimLayerInstanceData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.LinkedAnimLayerInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLinkedAnimLayerInstanceData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLinkedAnimLayerInstanceData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLinkedAnimLayerInstanceData A, FLinkedAnimLayerInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLinkedAnimLayerInstanceData A, FLinkedAnimLayerInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLinkedAnimLayerInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UAnimInstance Instance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Instance, __ReturnBuffer);

					return *(UAnimInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Instance, __InBuffer);
				}
			}
		}

		public TMap<FName, TWeakObjectPtr<UAnimInstance>> LinkedFunctions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LinkedFunctions, __ReturnBuffer);

					return *(TMap<FName, TWeakObjectPtr<UAnimInstance>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LinkedFunctions, __InBuffer);
				}
			}
		}

		private static uint __Instance = 0;

		private static uint __LinkedFunctions = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}