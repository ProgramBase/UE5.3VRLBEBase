using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DebugCameraController")]
	public partial class ADebugCameraController : APlayerController, IStaticClass
	{
		public bool bShowSelectedInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowSelectedInfo, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowSelectedInfo, __InBuffer);
				}
			}
		}

		public bool bIsFrozenRendering
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsFrozenRendering, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsFrozenRendering, __InBuffer);
				}
			}
		}

		public bool bIsOrbitingSelectedActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsOrbitingSelectedActor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsOrbitingSelectedActor, __InBuffer);
				}
			}
		}

		public bool bOrbitPivotUseCenter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOrbitPivotUseCenter, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOrbitPivotUseCenter, __InBuffer);
				}
			}
		}

		public bool bEnableBufferVisualization
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBufferVisualization, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBufferVisualization, __InBuffer);
				}
			}
		}

		public bool bEnableBufferVisualizationFullMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBufferVisualizationFullMode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableBufferVisualizationFullMode, __InBuffer);
				}
			}
		}

		public bool bIsBufferVisualizationInputSetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsBufferVisualizationInputSetup, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsBufferVisualizationInputSetup, __InBuffer);
				}
			}
		}

		public bool bLastDisplayEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLastDisplayEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLastDisplayEnabled, __InBuffer);
				}
			}
		}

		public UDrawFrustumComponent DrawFrustum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DrawFrustum, __ReturnBuffer);

					return *(UDrawFrustumComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DrawFrustum, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<AActor> SelectedActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedActor, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedActor, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UPrimitiveComponent> SelectedComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedComponent, __ReturnBuffer);

					return *(TWeakObjectPtr<UPrimitiveComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedComponent, __InBuffer);
				}
			}
		}

		public FHitResult SelectedHitPoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedHitPoint, __ReturnBuffer);

					return *(FHitResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedHitPoint, __InBuffer);
				}
			}
		}

		public APlayerController OriginalControllerRef
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalControllerRef, __ReturnBuffer);

					return *(APlayerController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalControllerRef, __InBuffer);
				}
			}
		}

		public UPlayer OriginalPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalPlayer, __ReturnBuffer);

					return *(UPlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalPlayer, __InBuffer);
				}
			}
		}

		public float SpeedScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpeedScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpeedScale, __InBuffer);
				}
			}
		}

		public float InitialMaxSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialMaxSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialMaxSpeed, __InBuffer);
				}
			}
		}

		public float InitialAccel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialAccel, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialAccel, __InBuffer);
				}
			}
		}

		public float InitialDecel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialDecel, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialDecel, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DebugCameraController");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ToggleDisplay()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ToggleDisplay);
			}
		}

		public virtual void ShowDebugSelectedInfo()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ShowDebugSelectedInfo);
			}
		}

		public virtual void SetPawnMovementSpeedScale(float NewSpeedScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewSpeedScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPawnMovementSpeedScale, __InBuffer);
			}
		}

		/// <param name="RestoredPC">
		/// The Player Controller that the player input is being returned to.
		/// </param>
		public virtual void ReceiveOnDeactivate(APlayerController RestoredPC)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = RestoredPC?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveOnDeactivate, __InBuffer);
			}
		}

		/// <param name="SelectHitLocation">
		/// The exact world-space location where the selection trace hit the New Selected Actor.
		/// </param>
		/// <param name="SelectHitNormal">
		/// The world-space surface normal of the New Selected Actor at the hit location.
		/// </param>
		public virtual void ReceiveOnActorSelected(AActor NewSelectedActor, FVector SelectHitLocation, FVector SelectHitNormal, FHitResult Hit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = NewSelectedActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SelectHitLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SelectHitNormal?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Hit?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveOnActorSelected, __InBuffer);
			}
		}

		/// <param name="OriginalPC">
		/// The active player controller before this debug camera controller was possessed by the player.
		/// </param>
		public virtual void ReceiveOnActivate(APlayerController OriginalPC)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OriginalPC?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveOnActivate, __InBuffer);
			}
		}

		public virtual AActor GetSelectedActor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectedActor, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		private static uint __bShowSelectedInfo = 0;

		private static uint __bIsFrozenRendering = 0;

		private static uint __bIsOrbitingSelectedActor = 0;

		private static uint __bOrbitPivotUseCenter = 0;

		private static uint __bEnableBufferVisualization = 0;

		private static uint __bEnableBufferVisualizationFullMode = 0;

		private static uint __bIsBufferVisualizationInputSetup = 0;

		private static uint __bLastDisplayEnabled = 0;

		private static uint __DrawFrustum = 0;

		private static uint __SelectedActor = 0;

		private static uint __SelectedComponent = 0;

		private static uint __SelectedHitPoint = 0;

		private static uint __OriginalControllerRef = 0;

		private static uint __OriginalPlayer = 0;

		private static uint __SpeedScale = 0;

		private static uint __InitialMaxSpeed = 0;

		private static uint __InitialAccel = 0;

		private static uint __InitialDecel = 0;

		private static uint __ToggleDisplay = 0;

		private static uint __ShowDebugSelectedInfo = 0;

		private static uint __SetPawnMovementSpeedScale = 0;

		private static uint __ReceiveOnDeactivate = 0;

		private static uint __ReceiveOnActorSelected = 0;

		private static uint __ReceiveOnActivate = 0;

		private static uint __GetSelectedActor = 0;
	}
}