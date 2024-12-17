using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PropertyEditorTestBasicStruct")]
	public partial class FPropertyEditorTestBasicStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.PropertyEditorTestBasicStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyEditorTestBasicStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyEditorTestBasicStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyEditorTestBasicStruct A, FPropertyEditorTestBasicStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyEditorTestBasicStruct A, FPropertyEditorTestBasicStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyEditorTestBasicStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int IntPropertyInsideAStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntPropertyInsideAStruct, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntPropertyInsideAStruct, __InBuffer);
				}
			}
		}

		public float FloatPropertyInsideAStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatPropertyInsideAStruct, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatPropertyInsideAStruct, __InBuffer);
				}
			}
		}

		public UObject ObjectPropertyInsideAStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectPropertyInsideAStruct, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectPropertyInsideAStruct, __InBuffer);
				}
			}
		}

		public FPropertyEditorTestSubStruct InnerStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InnerStruct, __ReturnBuffer);

					return *(FPropertyEditorTestSubStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InnerStruct, __InBuffer);
				}
			}
		}

		private static uint __IntPropertyInsideAStruct = 0;

		private static uint __FloatPropertyInsideAStruct = 0;

		private static uint __ObjectPropertyInsideAStruct = 0;

		private static uint __InnerStruct = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}