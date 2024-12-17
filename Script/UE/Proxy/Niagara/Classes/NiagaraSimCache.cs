using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSimCache")]
	public partial class UNiagaraSimCache : UObject, IStaticClass
	{
		public FGuid CacheGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheGuid, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UNiagaraSystem> SoftNiagaraSystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoftNiagaraSystem, __ReturnBuffer);

					return *(TSoftObjectPtr<UNiagaraSystem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoftNiagaraSystem, __InBuffer);
				}
			}
		}

		public float StartSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartSeconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartSeconds, __InBuffer);
				}
			}
		}

		public float DurationSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DurationSeconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DurationSeconds, __InBuffer);
				}
			}
		}

		public FNiagaraSimCacheCreateParameters CreateParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CreateParameters, __ReturnBuffer);

					return *(FNiagaraSimCacheCreateParameters*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CreateParameters, __InBuffer);
				}
			}
		}

		public bool bNeedsReadComponentMappingRecache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bNeedsReadComponentMappingRecache, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bNeedsReadComponentMappingRecache, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraVMExecutableDataId> CachedScriptVMIds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedScriptVMIds, __ReturnBuffer);

					return *(TArray<FNiagaraVMExecutableDataId>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedScriptVMIds, __InBuffer);
				}
			}
		}

		public FNiagaraSimCacheLayout CacheLayout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheLayout, __ReturnBuffer);

					return *(FNiagaraSimCacheLayout*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheLayout, __InBuffer);
				}
			}
		}

		public TArray<FNiagaraSimCacheFrame> CacheFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CacheFrames, __ReturnBuffer);

					return *(TArray<FNiagaraSimCacheFrame>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CacheFrames, __InBuffer);
				}
			}
		}

		public TMap<FNiagaraVariableBase, UObject> DataInterfaceStorage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataInterfaceStorage, __ReturnBuffer);

					return *(TMap<FNiagaraVariableBase, UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataInterfaceStorage, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraSimCache");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ReadVectorAttribute(ref TArray<FVector> OutValues, FName AttributeName, FName EmitterName, int FrameIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadVectorAttribute, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FVector>*)(__OutBuffer);

			}
		}

		public virtual void ReadVector4Attribute(ref TArray<FVector4> OutValues, FName AttributeName, FName EmitterName, int FrameIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadVector4Attribute, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FVector4>*)(__OutBuffer);

			}
		}

		public virtual void ReadVector2Attribute(ref TArray<FVector2D> OutValues, FName AttributeName, FName EmitterName, int FrameIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadVector2Attribute, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FVector2D>*)(__OutBuffer);

			}
		}

		public virtual void ReadQuatAttributeWithRebase(ref TArray<FQuat> OutValues, FQuat Quat, FName AttributeName = null, FName EmitterName = null, int FrameIndex = 0)
		{
			unsafe
			{
				AttributeName ??= new FName("MeshOrientation");

				EmitterName ??= new FName("None");

				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Quat?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 32) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadQuatAttributeWithRebase, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FQuat>*)(__OutBuffer);

			}
		}

		public virtual void ReadQuatAttribute(ref TArray<FQuat> OutValues, FName AttributeName = null, FName EmitterName = null, bool bLocalSpaceToWorld = true, int FrameIndex = 0)
		{
			unsafe
			{
				AttributeName ??= new FName("MeshOrientation");

				EmitterName ??= new FName("None");

				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bLocalSpaceToWorld;

				*(int*)(__InBuffer + 25) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadQuatAttribute, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FQuat>*)(__OutBuffer);

			}
		}

		public virtual void ReadPositionAttributeWithRebase(ref TArray<FVector> OutValues, FTransform Transform, FName AttributeName = null, FName EmitterName = null, int FrameIndex = 0)
		{
			unsafe
			{
				AttributeName ??= new FName("Position");

				EmitterName ??= new FName("None");

				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 32) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadPositionAttributeWithRebase, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FVector>*)(__OutBuffer);

			}
		}

		public virtual void ReadPositionAttribute(ref TArray<FVector> OutValues, FName AttributeName = null, FName EmitterName = null, bool bLocalSpaceToWorld = true, int FrameIndex = 0)
		{
			unsafe
			{
				AttributeName ??= new FName("Position");

				EmitterName ??= new FName("None");

				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bLocalSpaceToWorld;

				*(int*)(__InBuffer + 25) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadPositionAttribute, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FVector>*)(__OutBuffer);

			}
		}

		public virtual void ReadIntAttribute(ref TArray<int> OutValues, FName AttributeName, FName EmitterName, int FrameIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadIntAttribute, __InBuffer, __OutBuffer);

				OutValues = *(TArray<int>*)(__OutBuffer);

			}
		}

		public virtual void ReadIDAttribute(ref TArray<FNiagaraID> OutValues, FName AttributeName, FName EmitterName, int FrameIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadIDAttribute, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FNiagaraID>*)(__OutBuffer);

			}
		}

		public virtual void ReadFloatAttribute(ref TArray<float> OutValues, FName AttributeName, FName EmitterName, int FrameIndex = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadFloatAttribute, __InBuffer, __OutBuffer);

				OutValues = *(TArray<float>*)(__OutBuffer);

			}
		}

		public virtual void ReadColorAttribute(ref TArray<FLinearColor> OutValues, FName AttributeName = null, FName EmitterName = null, int FrameIndex = 0)
		{
			unsafe
			{
				AttributeName ??= new FName("Color");

				EmitterName ??= new FName("None");

				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = OutValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EmitterName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = FrameIndex;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ReadColorAttribute, __InBuffer, __OutBuffer);

				OutValues = *(TArray<FLinearColor>*)(__OutBuffer);

			}
		}

		public virtual bool IsEmpty()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEmpty, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsCacheValid()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsCacheValid, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetStartSeconds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetStartSeconds, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual int GetNumFrames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumFrames, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumEmitters()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumEmitters, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual TArray<FName> GetEmitterNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEmitterNames, __ReturnBuffer);

				return *(TArray<FName>*)__ReturnBuffer;
			}
		}

		public virtual FName GetEmitterName(int EmitterIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EmitterIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetEmitterName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual ENiagaraSimCacheAttributeCaptureMode GetAttributeCaptureMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAttributeCaptureMode, __ReturnBuffer);

				return *(ENiagaraSimCacheAttributeCaptureMode*)__ReturnBuffer;
			}
		}

		private static uint __CacheGuid = 0;

		private static uint __SoftNiagaraSystem = 0;

		private static uint __StartSeconds = 0;

		private static uint __DurationSeconds = 0;

		private static uint __CreateParameters = 0;

		private static uint __bNeedsReadComponentMappingRecache = 0;

		private static uint __CachedScriptVMIds = 0;

		private static uint __CacheLayout = 0;

		private static uint __CacheFrames = 0;

		private static uint __DataInterfaceStorage = 0;

		private static uint __ReadVectorAttribute = 0;

		private static uint __ReadVector4Attribute = 0;

		private static uint __ReadVector2Attribute = 0;

		private static uint __ReadQuatAttributeWithRebase = 0;

		private static uint __ReadQuatAttribute = 0;

		private static uint __ReadPositionAttributeWithRebase = 0;

		private static uint __ReadPositionAttribute = 0;

		private static uint __ReadIntAttribute = 0;

		private static uint __ReadIDAttribute = 0;

		private static uint __ReadFloatAttribute = 0;

		private static uint __ReadColorAttribute = 0;

		private static uint __IsEmpty = 0;

		private static uint __IsCacheValid = 0;

		private static uint __GetStartSeconds = 0;

		private static uint __GetNumFrames = 0;

		private static uint __GetNumEmitters = 0;

		private static uint __GetEmitterNames = 0;

		private static uint __GetEmitterName = 0;

		private static uint __GetAttributeCaptureMode = 0;
	}
}