data = lambda: [int(x) for x in open('input.txt').read().strip().split(',')]

def func(data, noun, verb):
  data[1] = noun
  data[2] = verb
  i = 0
  while True:
    if data[i] == 1:
      data[data[i+3]] = data[data[i+1]] + data[data[i+2]]
    elif data[i] == 2:
      data[data[i+3]] = data[data[i+1]] * data[data[i+2]]
    elif data[i] == 99:
      break
    else:
      break
    i = i+4
  return data[0]

print(func(data(), 12, 2))

for noun in range(99):
  for verb in range(99):
    if func(data(), noun, verb) == 19690720:
      print(100 * noun + verb)
      break
  else:
    continue
  break
