using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PreviewGeometry")]
	public partial class UPreviewGeometry : UObject, IStaticClass
	{
		public APreviewGeometryActor ParentActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParentActor, __ReturnBuffer);

					return *(APreviewGeometryActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParentActor, __InBuffer);
				}
			}
		}

		public TMap<FString, UTriangleSetComponent> TriangleSets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TriangleSets, __ReturnBuffer);

					return *(TMap<FString, UTriangleSetComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TriangleSets, __InBuffer);
				}
			}
		}

		public TMap<FString, ULineSetComponent> LineSets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LineSets, __ReturnBuffer);

					return *(TMap<FString, ULineSetComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LineSets, __InBuffer);
				}
			}
		}

		public TMap<FString, UPointSetComponent> PointSets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PointSets, __ReturnBuffer);

					return *(TMap<FString, UPointSetComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PointSets, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PreviewGeometry");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// true if the PointSetComponent was found and updated
		/// </returns>
		public virtual bool SetPointSetVisibility(FString PointSetIdentifier, bool bVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PointSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bVisible;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetPointSetVisibility, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the PointSetComponent was found and updated
		/// </returns>
		public virtual bool SetPointSetMaterial(FString PointSetIdentifier, UMaterialInterface NewMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PointSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewMaterial?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetPointSetMaterial, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the LineSetComponent was found and updated
		/// </returns>
		public virtual bool SetLineSetVisibility(FString LineSetIdentifier, bool bVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = LineSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bVisible;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLineSetVisibility, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the LineSetComponent was found and updated
		/// </returns>
		public virtual bool SetLineSetMaterial(FString LineSetIdentifier, UMaterialInterface NewMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LineSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewMaterial?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetLineSetMaterial, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetAllPointSetsMaterial(UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllPointSetsMaterial, __InBuffer);
			}
		}

		public virtual void SetAllLineSetsMaterial(UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAllLineSetsMaterial, __InBuffer);
			}
		}

		/// <param name="bDestroy">
		/// if true, component will unregistered and destroyed. 
		/// </param>
		/// <returns>
		/// true if the PointSetComponent was found and removed
		/// </returns>
		public virtual bool RemovePointSet(FString PointSetIdentifier, bool bDestroy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = PointSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDestroy;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemovePointSet, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bDestroy">
		/// if true, component will unregistered and destroyed. 
		/// </param>
		/// <returns>
		/// true if the LineSetComponent was found and removed
		/// </returns>
		public virtual bool RemoveLineSet(FString LineSetIdentifier, bool bDestroy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = LineSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDestroy;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveLineSet, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bDestroy">
		/// if true, the components will unregistered and destroyed.
		/// </param>
		public virtual void RemoveAllPointSets(bool bDestroy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bDestroy;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveAllPointSets, __InBuffer);
			}
		}

		/// <param name="bDestroy">
		/// if true, the components will unregistered and destroyed.
		/// </param>
		public virtual void RemoveAllLineSets(bool bDestroy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bDestroy;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveAllLineSets, __InBuffer);
			}
		}

		/// <returns>
		/// the preview geometry actor created by this class */
		/// </returns>
		public virtual APreviewGeometryActor GetActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetActor, __ReturnBuffer);

				return *(APreviewGeometryActor*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the TriangleSetComponent with the given TriangleSetIdentifier, or nullptr if not found */
		/// </returns>
		public virtual UTriangleSetComponent FindTriangleSet(FString TriangleSetIdentifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TriangleSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindTriangleSet, __InBuffer, __ReturnBuffer);

				return *(UTriangleSetComponent*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the PointSetComponent with the given PointSetIdentifier, or nullptr if not found */
		/// </returns>
		public virtual UPointSetComponent FindPointSet(FString PointSetIdentifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PointSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindPointSet, __InBuffer, __ReturnBuffer);

				return *(UPointSetComponent*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the LineSetComponent with the given LineSetIdentifier, or nullptr if not found */
		/// </returns>
		public virtual ULineSetComponent FindLineSet(FString LineSetIdentifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LineSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindLineSet, __InBuffer, __ReturnBuffer);

				return *(ULineSetComponent*)__ReturnBuffer;
			}
		}

		public virtual void Disconnect()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Disconnect);
			}
		}

		public virtual void CreateInWorld(UWorld World, FTransform WithTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WithTransform?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CreateInWorld, __InBuffer);
			}
		}

		public virtual UTriangleSetComponent AddTriangleSet(FString TriangleSetIdentifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TriangleSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddTriangleSet, __InBuffer, __ReturnBuffer);

				return *(UTriangleSetComponent*)__ReturnBuffer;
			}
		}

		public virtual UPointSetComponent AddPointSet(FString PointSetIdentifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PointSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddPointSet, __InBuffer, __ReturnBuffer);

				return *(UPointSetComponent*)__ReturnBuffer;
			}
		}

		public virtual ULineSetComponent AddLineSet(FString LineSetIdentifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LineSetIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddLineSet, __InBuffer, __ReturnBuffer);

				return *(ULineSetComponent*)__ReturnBuffer;
			}
		}

		private static uint __ParentActor = 0;

		private static uint __TriangleSets = 0;

		private static uint __LineSets = 0;

		private static uint __PointSets = 0;

		private static uint __SetPointSetVisibility = 0;

		private static uint __SetPointSetMaterial = 0;

		private static uint __SetLineSetVisibility = 0;

		private static uint __SetLineSetMaterial = 0;

		private static uint __SetAllPointSetsMaterial = 0;

		private static uint __SetAllLineSetsMaterial = 0;

		private static uint __RemovePointSet = 0;

		private static uint __RemoveLineSet = 0;

		private static uint __RemoveAllPointSets = 0;

		private static uint __RemoveAllLineSets = 0;

		private static uint __GetActor = 0;

		private static uint __FindTriangleSet = 0;

		private static uint __FindPointSet = 0;

		private static uint __FindLineSet = 0;

		private static uint __Disconnect = 0;

		private static uint __CreateInWorld = 0;

		private static uint __AddTriangleSet = 0;

		private static uint __AddPointSet = 0;

		private static uint __AddLineSet = 0;
	}
}