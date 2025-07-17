# BandwidthLogger

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public double AvgBitsDownPerSecond => avgBitsDownPerSecond;
- - public double AvgBitsUpPerSecond => avgBitsUpPerSecond;
- - public double BitsDownPerSecond => lastBitsDownPerSecond;
- - public double BitsUpPerSecond => lastBitsUpPerSecond;
- - public double TotalBitsDown => totalBitsDown;
- - public double TotalBitsUp => totalBitsUp;
- - public double TotalMs => totalMs;
- - public Queue<double> LoggedAvgBitsUp => bitsUp;
- - public Queue<double> LoggedAvgBitsDown => bitsDown;
- - public void Update()
- - public void RecordBytesDown(long bytes)
- - public void RecordBytesUp(long bytes)

## Private Members
- - private long bitsDownSinceLastUpdate;
- - private long bitsUpSinceLastUpdate;
- - private DateTime lastUpdateTime = DateTime.UtcNow;
- - private double lastBitsDownPerSecond;
- - private double lastBitsUpPerSecond;
- - private double avgBitsUpPerSecond;
- - private long bitsUpPerSecondCount;
- - private double avgBitsDownPerSecond;
- - private long bitsDownPerSecondCount;
- - private long totalBitsDown;
- - private long totalBitsUp;
- - private double totalMs;
- - private int queueCapacity = 100;
- - private Queue<double> bitsUp = new Queue<double>();
- - private Queue<double> bitsDown = new Queue<double>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
