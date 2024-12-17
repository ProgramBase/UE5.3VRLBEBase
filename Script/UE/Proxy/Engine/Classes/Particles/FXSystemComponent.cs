using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.FXSystemComponent")]
	public partial class UFXSystemComponent : UPrimitiveComponent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.FXSystemComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetVectorParameter(FName ParameterName, FVector Param)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVectorParameter, __InBuffer);
			}
		}

		/// <see>
		/// SetAutoAttachmentParameters()
		/// </see>
		public virtual void SetUseAutoManageAttachment(bool bAutoManage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bAutoManage;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUseAutoManageAttachment, __InBuffer);
			}
		}

		public virtual void SetIntParameter(FName ParameterName, int Param)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Param;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIntParameter, __InBuffer);
			}
		}

		public virtual void SetFloatParameter(FName ParameterName, float Param)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Param;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFloatParameter, __InBuffer);
			}
		}

		/// <param name="EmitterName">
		/// The name of the sub-emitter to set it on
		/// </param>
		/// <param name="bNewEnableState">
		/// The value to set it to
		/// </param>
		public virtual void SetEmitterEnable(FName EmitterName, bool bNewEnableState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bNewEnableState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEmitterEnable, __InBuffer);
			}
		}

		public virtual void SetColorParameter(FName ParameterName, FLinearColor Param)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetColorParameter, __InBuffer);
			}
		}

		public virtual void SetBoolParameter(FName ParameterName, bool Param)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Param;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoolParameter, __InBuffer);
			}
		}

		/// <param name="Parent">
		/// Component to attach to.
		/// </param>
		/// <param name="SocketName">
		/// Socket on Parent to attach to.
		/// </param>
		/// <param name="LocationRule">
		/// Option for how we handle our location when we attach to Parent.
		/// </param>
		/// <param name="RotationRule">
		/// Option for how we handle our rotation when we attach to Parent.
		/// </param>
		/// <param name="ScaleRule">
		/// Option for how we handle our scale when we attach to Parent.
		/// </param>
		/// <see>
		/// bAutoManageAttachment, AutoAttachParent, AutoAttachSocketName, AutoAttachLocationRule, AutoAttachRotationRule, AutoAttachScaleRule
		/// </see>
		public virtual void SetAutoAttachmentParameters(USceneComponent Parent, FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[19];

				*(nint*)(__InBuffer) = Parent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)LocationRule;

				*(byte*)(__InBuffer + 17) = (byte)RotationRule;

				*(byte*)(__InBuffer + 18) = (byte)ScaleRule;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAutoAttachmentParameters, __InBuffer);
			}
		}

		public virtual void SetActorParameter(FName ParameterName, AActor Param)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ParameterName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorParameter, __InBuffer);
			}
		}

		public virtual void ReleaseToPool()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReleaseToPool);
			}
		}

		public virtual UFXSystemAsset GetFXSystemAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetFXSystemAsset, __ReturnBuffer);

				return *(UFXSystemAsset*)__ReturnBuffer;
			}
		}

		private static uint __SetVectorParameter = 0;

		private static uint __SetUseAutoManageAttachment = 0;

		private static uint __SetIntParameter = 0;

		private static uint __SetFloatParameter = 0;

		private static uint __SetEmitterEnable = 0;

		private static uint __SetColorParameter = 0;

		private static uint __SetBoolParameter = 0;

		private static uint __SetAutoAttachmentParameters = 0;

		private static uint __SetActorParameter = 0;

		private static uint __ReleaseToPool = 0;

		private static uint __GetFXSystemAsset = 0;
	}
}