using Script.CoreUObject;
using Script.UnrealEd;
using Script.ControlRig;
using Script.Library;
using Script.ControlRigDeveloper;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigBlueprintFactory")]
	public partial class UControlRigBlueprintFactory : UFactory, IStaticClass
	{
		public TSubclassOf<UControlRig> ParentClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParentClass, __ReturnBuffer);

					return *(TSubclassOf<UControlRig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParentClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRigEditor.ControlRigBlueprintFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InDesiredPackagePath">
		/// The package path to use for the control rig asset
		/// </param>
		public static UControlRigBlueprint CreateNewControlRigAsset(FString InDesiredPackagePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InDesiredPackagePath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateNewControlRigAsset, __InBuffer, __ReturnBuffer);

				return *(UControlRigBlueprint*)__ReturnBuffer;
			}
		}

		/// <param name="InSelectedObject">
		/// The SkeletalMesh / Skeleton object to base the control rig asset on
		/// </param>
		public static UControlRigBlueprint CreateControlRigFromSkeletalMeshOrSkeleton(UObject InSelectedObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSelectedObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateControlRigFromSkeletalMeshOrSkeleton, __InBuffer, __ReturnBuffer);

				return *(UControlRigBlueprint*)__ReturnBuffer;
			}
		}

		private static uint __ParentClass = 0;

		private static uint __CreateNewControlRigAsset = 0;

		private static uint __CreateControlRigFromSkeletalMeshOrSkeleton = 0;
	}
}