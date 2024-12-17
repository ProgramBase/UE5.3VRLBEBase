using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.ModelingObjectsCreationAPI")]
	public partial class UModelingObjectsCreationAPI : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.ModelingObjectsCreationAPI");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// a results data structure, containing a result code and information about any new objects created
		/// </returns>
		public virtual FCreateTextureObjectResult CreateTextureObject(FCreateTextureObjectParams CreateTexParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CreateTexParams?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateTextureObject, __InBuffer, __ReturnBuffer);

				return *(FCreateTextureObjectResult*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// a results data structure, containing a result code and information about any new objects created
		/// </returns>
		public virtual FCreateActorResult CreateNewActor(FCreateActorParams CreateActorParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CreateActorParams?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateNewActor, __InBuffer, __ReturnBuffer);

				return *(FCreateActorResult*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// a results data structure, containing a result code and information about any new objects created
		/// </returns>
		public virtual FCreateMeshObjectResult CreateMeshObject(FCreateMeshObjectParams CreateMeshParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CreateMeshParams?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateMeshObject, __InBuffer, __ReturnBuffer);

				return *(FCreateMeshObjectResult*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// a results data structure, containing a result code and information about any new objects created
		/// </returns>
		public virtual FCreateMaterialObjectResult CreateMaterialObject(FCreateMaterialObjectParams CreateMaterialParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CreateMaterialParams?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateMaterialObject, __InBuffer, __ReturnBuffer);

				return *(FCreateMaterialObjectResult*)__ReturnBuffer;
			}
		}

		private static uint __CreateTextureObject = 0;

		private static uint __CreateNewActor = 0;

		private static uint __CreateMeshObject = 0;

		private static uint __CreateMaterialObject = 0;
	}
}