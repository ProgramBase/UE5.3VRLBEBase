using Script.CoreUObject;
using Script.Engine;
using Script.ChaosSolverEngine;
using Script.Library;
using Script.Chaos;

namespace Script.FieldSystemEngine
{
	[PathName("/Script/FieldSystemEngine.FieldSystemComponent")]
	public partial class UFieldSystemComponent : UPrimitiveComponent, IStaticClass
	{
		public UFieldSystem FieldSystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FieldSystem, __ReturnBuffer);

					return *(UFieldSystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FieldSystem, __InBuffer);
				}
			}
		}

		public bool bIsWorldField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsWorldField, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsWorldField, __InBuffer);
				}
			}
		}

		public bool bIsChaosField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsChaosField, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsChaosField, __InBuffer);
				}
			}
		}

		public TArray<TSoftObjectPtr<AChaosSolverActor>> SupportedSolvers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedSolvers, __ReturnBuffer);

					return *(TArray<TSoftObjectPtr<AChaosSolverActor>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedSolvers, __InBuffer);
				}
			}
		}

		public FFieldObjectCommands ConstructionCommands
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstructionCommands, __ReturnBuffer);

					return *(FFieldObjectCommands*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstructionCommands, __InBuffer);
				}
			}
		}

		public FFieldObjectCommands BufferCommands
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BufferCommands, __ReturnBuffer);

					return *(FFieldObjectCommands*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BufferCommands, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FieldSystemEngine.FieldSystemComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ResetFieldSystem()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetFieldSystem);
			}
		}

		public virtual void RemovePersistentFields()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RemovePersistentFields);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Position">
		/// The origin point of the force
		/// </param>
		/// <param name="Direction">
		/// The direction of the linear force
		/// </param>
		/// <param name="Radius">
		/// Radial influence from the position, positions further away are weaker.
		/// </param>
		/// <param name="Magnitude">
		/// The size of the linear force.
		/// </param>
		public virtual void ApplyUniformVectorFalloffForce(bool Enabled, FVector Position, FVector Direction, float Radius, float Magnitude)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(bool*)(__InBuffer) = Enabled;

				*(nint*)(__InBuffer + 1) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 17) = Radius;

				*(float*)(__InBuffer + 21) = Magnitude;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyUniformVectorFalloffForce, __InBuffer);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Position">
		/// The origin point of the force
		/// </param>
		/// <param name="Radius">
		/// Radial influence from the position, positions further away are weaker.
		/// </param>
		/// <param name="Magnitude">
		/// The size of the linear force.
		/// </param>
		/// <param name="Iterations">
		/// Levels of evaluation into the cluster hierarchy.
		/// </param>
		public virtual void ApplyStrainField(bool Enabled, FVector Position, float Radius, float Magnitude, int Iterations)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(bool*)(__InBuffer) = Enabled;

				*(nint*)(__InBuffer + 1) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 9) = Radius;

				*(float*)(__InBuffer + 13) = Magnitude;

				*(int*)(__InBuffer + 17) = Iterations;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyStrainField, __InBuffer);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Position">
		/// The location of the command
		/// </param>
		/// <param name="Radius">
		/// Radial influence from the position
		/// </param>
		public virtual void ApplyStayDynamicField(bool Enabled, FVector Position, float Radius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(bool*)(__InBuffer) = Enabled;

				*(nint*)(__InBuffer + 1) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 9) = Radius;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyStayDynamicField, __InBuffer);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Position">
		/// The origin point of the force
		/// </param>
		/// <param name="Radius">
		/// Radial influence from the position, positions further away are weaker.
		/// </param>
		/// <param name="Magnitude">
		/// The size of the linear force.
		/// </param>
		public virtual void ApplyRadialVectorFalloffForce(bool Enabled, FVector Position, float Radius, float Magnitude)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(bool*)(__InBuffer) = Enabled;

				*(nint*)(__InBuffer + 1) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 9) = Radius;

				*(float*)(__InBuffer + 13) = Magnitude;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyRadialVectorFalloffForce, __InBuffer);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Position">
		/// The origin point of the force
		/// </param>
		/// <param name="Magnitude">
		/// The size of the linear force.
		/// </param>
		public virtual void ApplyRadialForce(bool Enabled, FVector Position, float Magnitude)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(bool*)(__InBuffer) = Enabled;

				*(nint*)(__InBuffer + 1) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 9) = Magnitude;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyRadialForce, __InBuffer);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Target">
		/// Type of field supported by the solver.
		/// </param>
		/// <param name="MetaData">
		/// Meta data used to assist in evaluation
		/// </param>
		/// <param name="Field">
		/// Base evaluation node for the field network.
		/// </param>
		public virtual void ApplyPhysicsField(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(bool*)(__InBuffer) = Enabled;

				*(byte*)(__InBuffer + 1) = (byte)Target;

				*(nint*)(__InBuffer + 2) = MetaData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 10) = Field?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyPhysicsField, __InBuffer);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Direction">
		/// The direction of the linear force
		/// </param>
		/// <param name="Magnitude">
		/// The size of the linear force.
		/// </param>
		public virtual void ApplyLinearForce(bool Enabled, FVector Direction, float Magnitude)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(bool*)(__InBuffer) = Enabled;

				*(nint*)(__InBuffer + 1) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 9) = Magnitude;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ApplyLinearForce, __InBuffer);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Target">
		/// Type of field supported by the solver.
		/// </param>
		/// <param name="MetaData">
		/// Meta data used to assist in evaluation
		/// </param>
		/// <param name="Field">
		/// Base evaluation node for the field network.
		/// </param>
		public virtual void AddPersistentField(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(bool*)(__InBuffer) = Enabled;

				*(byte*)(__InBuffer + 1) = (byte)Target;

				*(nint*)(__InBuffer + 2) = MetaData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 10) = Field?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddPersistentField, __InBuffer);
			}
		}

		/// <param name="Enabled">
		/// Is this force enabled for evaluation.
		/// </param>
		/// <param name="Target">
		/// Type of field supported by the solver.
		/// </param>
		/// <param name="MetaData">
		/// Meta data used to assist in evaluation
		/// </param>
		/// <param name="Field">
		/// Base evaluation node for the field network.
		/// </param>
		public virtual void AddFieldCommand(bool Enabled, EFieldPhysicsType Target, UFieldSystemMetaData MetaData, UFieldNodeBase Field)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(bool*)(__InBuffer) = Enabled;

				*(byte*)(__InBuffer + 1) = (byte)Target;

				*(nint*)(__InBuffer + 2) = MetaData?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 10) = Field?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddFieldCommand, __InBuffer);
			}
		}

		private static uint __FieldSystem = 0;

		private static uint __bIsWorldField = 0;

		private static uint __bIsChaosField = 0;

		private static uint __SupportedSolvers = 0;

		private static uint __ConstructionCommands = 0;

		private static uint __BufferCommands = 0;

		private static uint __ResetFieldSystem = 0;

		private static uint __RemovePersistentFields = 0;

		private static uint __ApplyUniformVectorFalloffForce = 0;

		private static uint __ApplyStrainField = 0;

		private static uint __ApplyStayDynamicField = 0;

		private static uint __ApplyRadialVectorFalloffForce = 0;

		private static uint __ApplyRadialForce = 0;

		private static uint __ApplyPhysicsField = 0;

		private static uint __ApplyLinearForce = 0;

		private static uint __AddPersistentField = 0;

		private static uint __AddFieldCommand = 0;
	}
}