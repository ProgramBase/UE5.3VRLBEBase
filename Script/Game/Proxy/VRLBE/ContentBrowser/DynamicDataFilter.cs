using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealCSharpEditor
{
	[PathName("/Script/UnrealCSharpEditor.DynamicDataFilter")]
	public partial class FDynamicDataFilter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealCSharpEditor.DynamicDataFilter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDynamicDataFilter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDynamicDataFilter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDynamicDataFilter A, FDynamicDataFilter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDynamicDataFilter A, FDynamicDataFilter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDynamicDataFilter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<TSubclassOf<UObject>> Classes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Classes, __ReturnBuffer);

					return *(TSet<TSubclassOf<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Classes, __InBuffer);
				}
			}
		}

		public TSet<FName> Folders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Folders, __ReturnBuffer);

					return *(TSet<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Folders, __InBuffer);
				}
			}
		}

		private static uint __Classes = 0;

		private static uint __Folders = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}