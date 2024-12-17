using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Kismet
{
	[PathName("/Script/Kismet.BlueprintCompiledData")]
	public partial class FBlueprintCompiledData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Kismet.BlueprintCompiledData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintCompiledData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlueprintCompiledData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlueprintCompiledData A, FBlueprintCompiledData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintCompiledData A, FBlueprintCompiledData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintCompiledData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UEdGraph> IntermediateGraphs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntermediateGraphs, __ReturnBuffer);

					return *(TArray<UEdGraph>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntermediateGraphs, __InBuffer);
				}
			}
		}

		private static uint __IntermediateGraphs = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}