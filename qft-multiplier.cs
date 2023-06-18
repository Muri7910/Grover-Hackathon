using Quantum;
using Quantum.Operations;
using System;
using System.Numerics;
using System.Collections.Generic;

namespace QuantumConsole
{
	public class QuantumTest
	{
		public static void Main()
		{
			QuantumComputer comp = QuantumComputer.GetInstance();
			Register x = comp.NewRegister(7, 3);
			Register y = comp.NewRegister(7, 3);
			Register z = comp.NewRegister(0, 6);
			comp.QFT(z);
			comp.PhaseKick(3.14159265358979, z[5], x[2], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(1.5707963267949, z[4], x[2], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.785398163397448, z[3], x[2], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.392699081698724, z[2], x[2], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.218166156499291, z[1], x[2], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.106901416684653, z[0], x[2], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			
			comp.PhaseKick(3.14159265358979, z[4], x[2], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(1.5707963267949, z[3], x[2], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.785398163397448, z[2], x[2], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.392699081698724, z[1], x[2], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.213802833369305, z[0], x[2], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)

			comp.PhaseKick(3.14159265358979, z[3], y[0], x[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(1.5707963267949, z[2], y[0], x[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.785398163397448, z[1], y[0], x[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.392699081698724, z[0], x[2], y[0]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			
			comp.PhaseKick(3.14159265358979, z[4], x[1], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(1.5707963267949, z[3], x[1], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.785398163397448, z[2], x[1], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.392699081698724, z[1], x[1], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.213802833369305, z[0], x[1], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)

			comp.PhaseKick(3.14159265358979, z[3], x[1], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(1.5707963267949, z[2], x[1], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.785398163397448, z[1], x[1], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.392699081698724, z[0], x[1], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			
			comp.PhaseKick(3.14159265358979, z[2], x[1], y[0]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(1.5707963267949, z[1], x[1], y[0]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.785398163397448, z[0], x[1], y[0]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)

			comp.PhaseKick(3.14159265358979, z[3], x[0], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(1.5707963267949, z[2], x[0], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.785398163397448, z[1], x[0], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.392699081698724, z[0], x[0], y[2]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			
			comp.PhaseKick(3.14159265358979, z[2], x[0], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(1.5707963267949, z[1], x[0], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(0.785398163397448, z[0], x[0], y[1]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)

			comp.PhaseKick(3.14159265358979, z[1], x[0], y[0]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			comp.PhaseKick(1.5707963267949, z[0], x[0], y[0]);		// PhaseKick(<gamma_value>, <target_bit>, ... <control_bits> ...)
			// example: apply Hadamard Gate on qubit number 0 (least significant) 
			comp.Swap(z[2], z[3]);
			comp.Swap(z[1], z[4]);
			comp.Swap(z[0], z[5]);
			comp.InverseQFT(z);
		}
	}
}
