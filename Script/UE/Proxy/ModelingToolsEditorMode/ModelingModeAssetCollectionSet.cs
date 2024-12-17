using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ModelingToolsEditorMode
{
	[PathName("/Script/ModelingToolsEditorMode.ModelingModeAssetCollectionSet")]
	public partial class FModelingModeAssetCollectionSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ModelingToolsEditorMode.ModelingModeAssetCollectionSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FModelingModeAssetCollectionSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FModelingModeAssetCollectionSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FModelingModeAssetCollectionSet A, FModelingModeAssetCollectionSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FModelingModeAssetCollectionSet A, FModelingModeAssetCollectionSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FModelingModeAssetCollectionSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public TArray<FCollectionReference> Collections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Collections, __ReturnBuffer);

					return *(TArray<FCollectionReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Collections, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __Collections = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}