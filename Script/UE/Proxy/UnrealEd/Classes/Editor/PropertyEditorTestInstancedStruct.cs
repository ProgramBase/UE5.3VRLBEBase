using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PropertyEditorTestInstancedStruct")]
	public partial class FPropertyEditorTestInstancedStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.PropertyEditorTestInstancedStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyEditorTestInstancedStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyEditorTestInstancedStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyEditorTestInstancedStruct A, FPropertyEditorTestInstancedStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyEditorTestInstancedStruct A, FPropertyEditorTestInstancedStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyEditorTestInstancedStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UPropertyEditorTestInstancedObject Object
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Object, __ReturnBuffer);

					return *(UPropertyEditorTestInstancedObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Object, __InBuffer);
				}
			}
		}

		private static uint __Object = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}