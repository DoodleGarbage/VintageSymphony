using Vintagestory.API.Client;
using VintageSymphony.Config;

namespace VintageSymphony.Engine;

public class TrackFilter
{
    private readonly Configuration configuration;
    private readonly string modId;

    public TrackFilter(Configuration configuration, string modId)
    {
        this.configuration = configuration;
        this.modId = modId;
        if (modId == "vintage-symphony-120x") {
            this.modId = "vintage-symphony";
        }
    }

    public bool KeepTrack(IMusicTrack track)
    {
        bool keep = false;
        if (track is SurfaceMusicTrack surfaceTrack)
        {
            var domain = surfaceTrack.Location.Domain;
            keep |= configuration.LoadGameMusic && domain == "game";
            keep |= configuration.LoadVintageSymphonyMusic && domain == modId;
        }
        else if (track is CaveMusicTrack)
        {
            keep |= configuration.LoadCaveTrack;
        }

        return keep;
    }
}