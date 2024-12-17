using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ReimportFbxSceneFactory")]
	public partial class UReimportFbxSceneFactory : UFbxSceneImportFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ReimportFbxSceneFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Obj">
		/// : type must be one of the following type
		/// UFbxSceneImportData
		/// UStaticMesh, USkeletalMesh, UAnimSequence: It must have been imported with the scene import so the AssetImportData point on a UFbxSceneImportData
		/// </param>
		public virtual void ScriptReimportHelper(UObject Obj)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Obj?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ScriptReimportHelper, __InBuffer);
			}
		}

		private static uint __ScriptReimportHelper = 0;
	}
}