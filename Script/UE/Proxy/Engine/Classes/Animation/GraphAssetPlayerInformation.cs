using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.GraphAssetPlayerInformation")]
	public partial class FGraphAssetPlayerInformation : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.GraphAssetPlayerInformation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGraphAssetPlayerInformation() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGraphAssetPlayerInformation() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGraphAssetPlayerInformation A, FGraphAssetPlayerInformation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGraphAssetPlayerInformation A, FGraphAssetPlayerInformation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGraphAssetPlayerInformation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> PlayerNodeIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlayerNodeIndices, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlayerNodeIndices, __InBuffer);
				}
			}
		}

		private static uint __PlayerNodeIndices = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}