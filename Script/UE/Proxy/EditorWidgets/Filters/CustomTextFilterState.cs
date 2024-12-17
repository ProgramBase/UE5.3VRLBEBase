using Script.CoreUObject;
using Script.Library;
using Script.ToolWidgets;

namespace Script.EditorWidgets
{
	[PathName("/Script/EditorWidgets.CustomTextFilterState")]
	public partial class FCustomTextFilterState : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorWidgets.CustomTextFilterState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCustomTextFilterState() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCustomTextFilterState() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCustomTextFilterState A, FCustomTextFilterState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCustomTextFilterState A, FCustomTextFilterState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCustomTextFilterState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIsChecked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsChecked, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsChecked, __InBuffer);
				}
			}
		}

		public bool bIsActive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsActive, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsActive, __InBuffer);
				}
			}
		}

		public FCustomTextFilterData FilterData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterData, __ReturnBuffer);

					return *(FCustomTextFilterData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterData, __InBuffer);
				}
			}
		}

		private static uint __bIsChecked = 0;

		private static uint __bIsActive = 0;

		private static uint __FilterData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}