using Script.CoreUObject;
using Script.Engine;
using Script.MRMesh.MockDataMeshTrackerComponent;
using Script.Library;

namespace Script.MRMesh
{
	[PathName("/Script/MRMesh.MockDataMeshTrackerComponent")]
	public partial class UMockDataMeshTrackerComponent : USceneComponent, IStaticClass
	{
		public FOnMockDataMeshTrackerUpdated OnMeshTrackerUpdated
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnMeshTrackerUpdated, __ReturnBuffer);

					return *(FOnMockDataMeshTrackerUpdated*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnMeshTrackerUpdated, __InBuffer);
				}
			}
		}

		public bool ScanWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScanWorld, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScanWorld, __InBuffer);
				}
			}
		}

		public bool RequestNormals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RequestNormals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RequestNormals, __InBuffer);
				}
			}
		}

		public bool RequestVertexConfidence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RequestVertexConfidence, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RequestVertexConfidence, __InBuffer);
				}
			}
		}

		public EMeshTrackerVertexColorMode VertexColorMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VertexColorMode, __ReturnBuffer);

					return *(EMeshTrackerVertexColorMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VertexColorMode, __InBuffer);
				}
			}
		}

		public TArray<FColor> BlockVertexColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlockVertexColors, __ReturnBuffer);

					return *(TArray<FColor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlockVertexColors, __InBuffer);
				}
			}
		}

		public FLinearColor VertexColorFromConfidenceZero
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VertexColorFromConfidenceZero, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VertexColorFromConfidenceZero, __InBuffer);
				}
			}
		}

		public FLinearColor VertexColorFromConfidenceOne
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VertexColorFromConfidenceOne, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VertexColorFromConfidenceOne, __InBuffer);
				}
			}
		}

		public float UpdateInterval
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateInterval, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateInterval, __InBuffer);
				}
			}
		}

		public UMRMeshComponent MRMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MRMesh, __ReturnBuffer);

					return *(UMRMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MRMesh, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MRMesh.MockDataMeshTrackerComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InMRMeshPtr">
		/// The procedural mesh component to unlink from the mesh tracking system.
		/// </param>
		public virtual void DisconnectMRMesh(UMRMeshComponent InMRMeshPtr)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMRMeshPtr?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DisconnectMRMesh, __InBuffer);
			}
		}

		/// <param name="InMRMeshPtr">
		/// The procedural mesh component to store the query result in.
		/// </param>
		public virtual void ConnectMRMesh(UMRMeshComponent InMRMeshPtr)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMRMeshPtr?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ConnectMRMesh, __InBuffer);
			}
		}

		private static uint __OnMeshTrackerUpdated = 0;

		private static uint __ScanWorld = 0;

		private static uint __RequestNormals = 0;

		private static uint __RequestVertexConfidence = 0;

		private static uint __VertexColorMode = 0;

		private static uint __BlockVertexColors = 0;

		private static uint __VertexColorFromConfidenceZero = 0;

		private static uint __VertexColorFromConfidenceOne = 0;

		private static uint __UpdateInterval = 0;

		private static uint __MRMesh = 0;

		private static uint __DisconnectMRMesh = 0;

		private static uint __ConnectMRMesh = 0;
	}
}