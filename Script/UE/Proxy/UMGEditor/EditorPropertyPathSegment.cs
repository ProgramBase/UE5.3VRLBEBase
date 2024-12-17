using Script.CoreUObject;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.EditorPropertyPathSegment")]
	public partial class FEditorPropertyPathSegment : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMGEditor.EditorPropertyPathSegment");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorPropertyPathSegment() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEditorPropertyPathSegment() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEditorPropertyPathSegment A, FEditorPropertyPathSegment B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorPropertyPathSegment A, FEditorPropertyPathSegment B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorPropertyPathSegment;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UStruct Struct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Struct, __ReturnBuffer);

					return *(UStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Struct, __InBuffer);
				}
			}
		}

		public FName MemberName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MemberName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MemberName, __InBuffer);
				}
			}
		}

		public FGuid MemberGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MemberGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MemberGuid, __InBuffer);
				}
			}
		}

		public bool IsProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IsProperty, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IsProperty, __InBuffer);
				}
			}
		}

		private static uint __Struct = 0;

		private static uint __MemberName = 0;

		private static uint __MemberGuid = 0;

		private static uint __IsProperty = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}