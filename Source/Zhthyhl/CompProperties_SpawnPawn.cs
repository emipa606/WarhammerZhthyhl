using RimWorld;
using Verse;

namespace Zhthyhl;

public class CompProperties_SpawnPawn : CompProperties_UseEffect
{
    public int amount = 1;

    public FactionDef forcedFaction;
    public PawnKindDef pawnKind;

    public string pawnSpawnedStringKey = "Zhthyhl answer";

    public bool sendMessage = true;

    public IntRange spawnIntervalRange = new IntRange(100, 100);

    public bool usePlayerFaction = false;

    public CompProperties_SpawnPawn()
    {
        compClass = typeof(CompUseEffect_SpawnPawn);
    }
}