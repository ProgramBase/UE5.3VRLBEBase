using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintComponentChangedPropertyInfo")]
	public partial class FBlueprintComponentChangedPropertyInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BlueprintComponentChangedPropertyInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlueprintComponentChangedPropertyInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBlueprintComponentChangedPropertyInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBlueprintComponentChangedPropertyInfo A, FBlueprintComponentChangedPropertyInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlueprintComponentChangedPropertyInfo A, FBlueprintComponentChangedPropertyInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlueprintComponentChangedPropertyInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName PropertyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyName, __InBuffer);
				}
			}
		}

		public int ArrayIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ArrayIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ArrayIndex, __InBuffer);
				}
			}
		}

		public UStruct PropertyScope
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyScope, __ReturnBuffer);

					return *(UStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyScope, __InBuffer);
				}
			}
		}

		private static uint __PropertyName = 0;

		private static uint __ArrayIndex = 0;

		private static uint __PropertyScope = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}