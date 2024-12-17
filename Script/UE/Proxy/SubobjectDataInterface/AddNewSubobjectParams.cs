using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.SubobjectDataInterface
{
	[PathName("/Script/SubobjectDataInterface.AddNewSubobjectParams")]
	public partial class FAddNewSubobjectParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SubobjectDataInterface.AddNewSubobjectParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAddNewSubobjectParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAddNewSubobjectParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAddNewSubobjectParams A, FAddNewSubobjectParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAddNewSubobjectParams A, FAddNewSubobjectParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAddNewSubobjectParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSubobjectDataHandle ParentHandle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParentHandle, __ReturnBuffer);

					return *(FSubobjectDataHandle*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParentHandle, __InBuffer);
				}
			}
		}

		public TSubclassOf<UObject> NewClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewClass, __InBuffer);
				}
			}
		}

		public UBlueprint BlueprintContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlueprintContext, __ReturnBuffer);

					return *(UBlueprint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlueprintContext, __InBuffer);
				}
			}
		}

		public bool bSkipMarkBlueprintModified
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSkipMarkBlueprintModified, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSkipMarkBlueprintModified, __InBuffer);
				}
			}
		}

		public bool bConformTransformToParent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bConformTransformToParent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bConformTransformToParent, __InBuffer);
				}
			}
		}

		private static uint __ParentHandle = 0;

		private static uint __NewClass = 0;

		private static uint __BlueprintContext = 0;

		private static uint __bSkipMarkBlueprintModified = 0;

		private static uint __bConformTransformToParent = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}