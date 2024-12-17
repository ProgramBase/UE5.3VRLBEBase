using Script.CoreUObject;
using Script.RigVM;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigShapeLibraryLink")]
	public partial class UControlRigShapeLibraryLink : UNameSpacedUserData, IStaticClass
	{
		public UControlRigShapeLibrary ShapeLibrary
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeLibrary, __ReturnBuffer);

					return *(UControlRigShapeLibrary*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeLibrary, __InBuffer);
				}
			}
		}

		public TArray<FName> ShapeNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeNames, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigShapeLibraryLink");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetShapeLibrary(UControlRigShapeLibrary InShapeLibrary)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InShapeLibrary?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetShapeLibrary, __InBuffer);
			}
		}

		public virtual UControlRigShapeLibrary GetShapeLibrary()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetShapeLibrary, __ReturnBuffer);

				return *(UControlRigShapeLibrary*)__ReturnBuffer;
			}
		}

		private static uint __ShapeLibrary = 0;

		private static uint __ShapeNames = 0;

		private static uint __SetShapeLibrary = 0;

		private static uint __GetShapeLibrary = 0;
	}
}