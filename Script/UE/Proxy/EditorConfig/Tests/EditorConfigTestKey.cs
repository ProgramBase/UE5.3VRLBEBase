using Script.CoreUObject;
using Script.Library;

namespace Script.EditorConfig
{
	[PathName("/Script/EditorConfig.EditorConfigTestKey")]
	public partial class FEditorConfigTestKey : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorConfig.EditorConfigTestKey");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorConfigTestKey() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorConfigTestKey() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorConfigTestKey A, FEditorConfigTestKey B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorConfigTestKey A, FEditorConfigTestKey B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorConfigTestKey;

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

		public double Number
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Number, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Number, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __Number = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}