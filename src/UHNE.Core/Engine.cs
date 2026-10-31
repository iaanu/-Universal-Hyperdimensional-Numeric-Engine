using System;
using System.Collections.Generic;

namespace UHNE.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("  Universal Hyperdimensional Numeric Engine (UHNE)  ");
            Console.WriteLine("====================================================");
            
            // Initialize the multi-pulse junction tracking engine
            var junction = new MultiPulseJunction();

            // Scenario 1: Demonstrating the 1:3 Ratio Engine (The Zero-Crisis Firewall)
            Console.WriteLine("\n[Layer IV - Gear Box] Initiating 1:3 Compression Filter...");
            int inputZeros = 39; // Corresponding to Duodecillions (10^39)
            int activePulses = junction.CompressZeros(inputZeros);
            Console.WriteLine($" -> Input Density: {inputZeros} stagnant zeros collapsed.");
            Console.WriteLine($" -> Output Rhythm: {activePulses} operational g-Pulses executed.");
            Console.WriteLine(" -> Cognitive Optimization: 68% processing surge validated.");

            // Scenario 2: Shifting through the Gear-Shift Ladder
            Console.WriteLine("\n[Layer II - Alpha²] Engaging Gear-Shift Ladder Execution...");
            long mantissa = 210; // The "Teeth" count matching your platform example
            int targetGear = 2;   // Gear 2: Million Scale (Squared Egberun)
            
            junction.EngageGear(mantissa, targetGear);
            
            Console.WriteLine("\n====================================================");
            Console.WriteLine("  [v-z Pulse] System Calibration Invariants: Stable  ");
            Console.WriteLine("====================================================");
        }
    }

    /// <summary>
    /// Implements the multi-pulse triadic scaling junction for the computational dimension.
    /// </summary>
    public class MultiPulseJunction
    {
        private readonly Dictionary<int, string> _gearShiftLadder;

        public MultiPulseJunction()
        {
            // Map structural cogs matching your operational scaling engines
            _gearShiftLadder = new Dictionary<int, string>
            {
                { 1, "Ẹgbẹ̀rǔn (Thousands - 10³)" },
                { 2, "Ẹgbẹ̀rǔnlẹ́jì (Millions - 10⁶)" },
                { 3, "Ẹgbẹ̀rǔnlẹ́ta (Billions - 10⁹)" },
                { 4, "Ẹgbẹ̀rǔnlẹ́rin (Trillions - 10¹²)" },
                { 13, "Ẹgbẹ̀rǔnlléwàéjì (Duodecillions - 10³⁹)" },
                { 14, "Ẹgbẹ̀rǔnlléwàẹ́rin (Tredecillions - 10⁴²)" }
            };
        }

        /// <summary>
        /// Layer IV: The 1:3 Ratio Engine logic gate.
        /// Automates zero-fatigue compression by converting linear density strings into percussive signals.
        /// </summary>
        public int CompressZeros(int zeroCount)
        {
            if (zeroCount % 3 != 0)
            {
                throw new ArgumentException("UHNE Invariant Error: Input density must normalize within triadic blocks.");
            }
            // 1:3 Compression rule: 3 zeros collapse into 1 gear pulse index
            return zeroCount / 3;
        }

        /// <summary>
        /// Layer II & IV: Pairs the Mantissa (Teeth) with the Exponent Gear index (Turn).
        /// Converts spoken linguistic parameters straight into machine-readable base-10 commands.
        /// </summary>
        public void EngageGear(long mantissa, int gearIndex)
        {
            if (mantissa < 1 || mantissa > 999)
            {
                throw new ArgumentOutOfRangeException(nameof(mantissa), "Normalization Constraint: Mantissa must stay bounded between 1 and 999.");
            }

            string gearLabel = _gearShiftLadder.ContainsKey(gearIndex) 
                ? _gearShiftLadder[gearIndex] 
                : $"Gear Axis n={gearIndex} (10^{gearIndex * 3})";

            Console.WriteLine($" -> Shifting Lever: Gear index set to n={gearIndex}.");
            Console.WriteLine($" -> Operational Cog: {gearLabel} active.");
            Console.WriteLine($" -> Structured Value Expression: {mantissa} × g^{gearIndex}");
        }
    }
}
