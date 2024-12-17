using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialCachedParameterEditorEntry")]
	public partial class FMaterialCachedParameterEditorEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialCachedParameterEditorEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialCachedParameterEditorEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialCachedParameterEditorEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialCachedParameterEditorEntry A, FMaterialCachedParameterEditorEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialCachedParameterEditorEntry A, FMaterialCachedParameterEditorEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialCachedParameterEditorEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMaterialCachedParameterEditorInfo> EditorInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EditorInfo, __ReturnBuffer);

					return *(TArray<FMaterialCachedParameterEditorInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EditorInfo, __InBuffer);
				}
			}
		}

		private static uint __EditorInfo = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}