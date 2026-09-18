-- Build: 64c73a4aa845e39cd57b8cd1165765c8
local M = {}

function M.clamp(value, minimum, maximum)
  return math.max(minimum, math.min(maximum, value))
end

return M
