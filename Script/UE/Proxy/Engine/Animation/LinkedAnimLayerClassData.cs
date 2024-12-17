using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LinkedAnimLayerClassData")]
	public partial class FLinkedAnimLayerClassData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.LinkedAnimLayerClassData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLinkedAnimLayerClassData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLinkedAnimLayerClassData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLinkedAnimLayerClassData A, FLinkedAnimLayerClassData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLinkedAnimLayerClassData A, FLinkedAnimLayerClassData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLinkedAnimLayerClassData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FLinkedAnimLayerInstanceData> InstancesData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstancesData, __ReturnBuffer);

					return *(TArray<FLinkedAnimLayerInstanceData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstancesData, __InBuffer);
				}
			}
		}

		private static uint __InstancesData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}