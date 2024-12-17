using Script.CoreUObject;
using Script.Engine;
using Script.NavigationSystem;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.NavLinkProxy")]
	public partial class ANavLinkProxy : AActor, IStaticClass, INavLinkHostInterface, INavRelevantInterface
	{
		public TArray<FNavigationLink> PointLinks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PointLinks, __ReturnBuffer);

					return *(TArray<FNavigationLink>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PointLinks, __InBuffer);
				}
			}
		}

		public TArray<FNavigationSegmentLink> SegmentLinks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SegmentLinks, __ReturnBuffer);

					return *(TArray<FNavigationSegmentLink>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SegmentLinks, __InBuffer);
				}
			}
		}

		public UNavLinkCustomComponent SmartLinkComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SmartLinkComp, __ReturnBuffer);

					return *(UNavLinkCustomComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SmartLinkComp, __InBuffer);
				}
			}
		}

		public bool bSmartLinkIsRelevant
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSmartLinkIsRelevant, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSmartLinkIsRelevant, __InBuffer);
				}
			}
		}

		public UNavLinkRenderingComponent EdRenderComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EdRenderComp, __ReturnBuffer);

					return *(UNavLinkRenderingComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EdRenderComp, __InBuffer);
				}
			}
		}

		public UBillboardComponent SpriteComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteComponent, __ReturnBuffer);

					return *(UBillboardComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteComponent, __InBuffer);
				}
			}
		}

		public FSmartLinkReachedSignature OnSmartLinkReached
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSmartLinkReached, __ReturnBuffer);

					return *(FSmartLinkReachedSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSmartLinkReached, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.NavLinkProxy");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void SetSmartLinkEnabled(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSmartLinkEnabled, __InBuffer);
			}
		}

		public virtual void ResumePathFollowing(AActor Agent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Agent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResumePathFollowing, __InBuffer);
			}
		}

		public virtual void ReceiveSmartLinkReached(AActor Agent, FVector Destination)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Agent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Destination?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveSmartLinkReached, __InBuffer);
			}
		}

		public virtual bool IsSmartLinkEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsSmartLinkEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasMovingAgents()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasMovingAgents, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void CopyEndPointsFromSimpleLinkToSmartLink()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CopyEndPointsFromSimpleLinkToSmartLink);
			}
		}

		private static uint __PointLinks = 0;

		private static uint __SegmentLinks = 0;

		private static uint __SmartLinkComp = 0;

		private static uint __bSmartLinkIsRelevant = 0;

		private static uint __EdRenderComp = 0;

		private static uint __SpriteComponent = 0;

		private static uint __OnSmartLinkReached = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetSmartLinkEnabled = 0;

		private static uint __ResumePathFollowing = 0;

		private static uint __ReceiveSmartLinkReached = 0;

		private static uint __IsSmartLinkEnabled = 0;

		private static uint __HasMovingAgents = 0;

		private static uint __CopyEndPointsFromSimpleLinkToSmartLink = 0;
	}
}