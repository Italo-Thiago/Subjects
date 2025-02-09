import time

start_time = time.time()

for i in range(10000000):
    pass

end_time = time.time()

duration = end_time - start_time
print("Duration", duration)