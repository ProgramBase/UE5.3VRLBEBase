using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigShapeLibrary")]
	public partial class UControlRigShapeLibrary : UObject, IStaticClass
	{
		public FControlRigShapeDefinition DefaultShape
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultShape, __ReturnBuffer);

					return *(FControlRigShapeDefinition*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultShape, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UMaterial> DefaultMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterial, __ReturnBuffer);

					return *(TSoftObjectPtr<UMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMaterial, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UMaterial> XRayMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __XRayMaterial, __ReturnBuffer);

					return *(TSoftObjectPtr<UMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __XRayMaterial, __InBuffer);
				}
			}
		}

		public FName MaterialColorParameter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialColorParameter, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialColorParameter, __InBuffer);
				}
			}
		}

		public TArray<FControlRigShapeDefinition> Shapes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Shapes, __ReturnBuffer);

					return *(TArray<FControlRigShapeDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Shapes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigShapeLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultShape = 0;

		private static uint __DefaultMaterial = 0;

		private static uint __XRayMaterial = 0;

		private static uint __MaterialColorParameter = 0;

		private static uint __Shapes = 0;
	}
}