using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PropertyEditorTestSubStruct")]
	public partial class FPropertyEditorTestSubStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.PropertyEditorTestSubStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyEditorTestSubStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyEditorTestSubStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyEditorTestSubStruct A, FPropertyEditorTestSubStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyEditorTestSubStruct A, FPropertyEditorTestSubStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyEditorTestSubStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int FirstProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FirstProperty, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FirstProperty, __InBuffer);
				}
			}
		}

		public int SecondProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SecondProperty, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SecondProperty, __InBuffer);
				}
			}
		}

		public FLinearColor CustomizedStructInsideUncustomizedStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomizedStructInsideUncustomizedStruct, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomizedStructInsideUncustomizedStruct, __InBuffer);
				}
			}
		}

		public FSoftObjectPath CustomizedStructInsideUncustomizedStruct2
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CustomizedStructInsideUncustomizedStruct2, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CustomizedStructInsideUncustomizedStruct2, __InBuffer);
				}
			}
		}

		private static uint __FirstProperty = 0;

		private static uint __SecondProperty = 0;

		private static uint __CustomizedStructInsideUncustomizedStruct = 0;

		private static uint __CustomizedStructInsideUncustomizedStruct2 = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}